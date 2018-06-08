using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Client.Utils;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.AnonCredsApi;
using Hyperledger.Indy.CryptoApi;
using Hyperledger.Indy.DidApi;
using Hyperledger.Indy.LedgerApi;
using Hyperledger.Indy.PairwiseApi;
using Hyperledger.Indy.PoolApi;
using Hyperledger.Indy.WalletApi;
using Indy.Agent.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client
{
    public class ClientExample
    {
        const string myWalletName = "ClientWallet";

        const string agentDid = "Th7MpTaRZVRYnPiabds81Y";

        string myDid;
        string myVk;
        string agentVk;

        Pool pool;
        Wallet wallet;

        public ClientExample()
        {
        }

        public async Task Initialize()
        {
            // 1. Create ledger config from genesis txn file
            await PoolUtils.CreatePoolLedgerConfig();

            // 2. Create and Open My Wallet
            await WalletUtils.CreateWalletAsync(PoolUtils.DEFAULT_POOL_NAME, myWalletName, "default", null, null);

            //3. Open pool and wallets in using statements to ensure they are closed when finished.         
            pool = await Pool.OpenPoolLedgerAsync(PoolUtils.DEFAULT_POOL_NAME, "{}");
            wallet = await Wallet.OpenWalletAsync(myWalletName, null, null);
        }

        public async Task Cleanup()
        {
            await wallet.CloseAsync();
            await pool.CloseAsync();

            await WalletUtils.DeleteWalletAsync(myWalletName, null);
            await PoolUtils.DeletePoolLedgerConfigAsync(PoolUtils.DEFAULT_POOL_NAME);
        }

        public async Task Execute()
        {
            Console.WriteLine("Running connection example");
            try
            {
                await Initialize();

                // Get and store agent did and key            
                agentVk = await Did.KeyForDidAsync(pool, wallet, agentDid);

                // Create My Did
                var createMyDidResult = await Did.CreateAndStoreMyDidAsync(wallet, "{}");
                myDid = createMyDidResult.Did;
                myVk = createMyDidResult.VerKey;

                Console.WriteLine("Fetching agent endpoint from ledger.");

                // Get and store agent endpoint and pubkey
                var endpoint = await Did.GetEndpointForDidAsync(wallet, pool, agentDid);
                await Did.SetEndpointForDidAsync(wallet, agentDid, endpoint.Address, agentVk);

                Console.WriteLine("Sending connection offer request to agent.");

                // Send a connection offer to agent and receive a challenge
                var connectionOffer = await Send<ConnectionOfferResponse>(new ConnectionOfferRequest());

                Console.WriteLine($"Sending connection acknowledgment.");

                // Send challenge back with myDid
                var connection = await Send<ConnectionResponse>(new ConnectionRequest { Did = myDid, Nonce = connectionOffer.Nonce });

                Console.WriteLine($"Creating pairwsie connection.");

                // Create pairwise did
                await Did.StoreTheirDidAsync(wallet, JsonConvert.SerializeObject(new { did = agentDid, verkey = agentVk }));
                await Pairwise.CreateAsync(wallet, agentDid, myDid, null);

                Console.WriteLine($"Requesting schema registration.");

                // Register schema
                var schemaReq = new SchemaCreateRequest { Name = "gov", Version = "1.0" };
                schemaReq.AttributeNames.AddRange(new[] { "name", "age", "sex" });

                var schema = await Send<SchemaCreateResponse>(schemaReq);

                Console.WriteLine($"Requesting credential definition.");

                // Register definition
                var credDef = await Send<CredentialDefinitionCreateResponse>(new CredentialDefinitionCreateRequest { SchemaId = schema.SchemaId });

                Console.WriteLine($"Sending request for credential offer.");

                // Request credential offer
                var offerReq = await Send<CredentialOfferResponse>(new CredentialOfferRequest { CredentialDefinitionId = credDef.CredentialDefinitionId });

                // Get credential definition json from ledger
                var l_credDefReq = await Ledger.BuildGetCredDefRequestAsync(myDid, credDef.CredentialDefinitionId);
                var l_credDefRes = await Ledger.SubmitRequestAsync(pool, l_credDefReq);
                var l_CredDef = await Ledger.ParseGetCredDefResponseAsync(l_credDefRes);

                Console.WriteLine($"Generating master secret and credential request.");

                // Create master secret and credential request
                await AnonCreds.ProverCreateMasterSecretAsync(wallet, "master_secret");
                var credReq = await AnonCreds.ProverCreateCredentialReqAsync(wallet, myDid, offerReq.CredentialOfferJson, l_CredDef.ObjectJson, "master_secret");

                // TODO: Complete demo with credential issuence and verification

                //var cred = await Send<CredentialResponse>(new CredentialRequest
                //{
                //    CredentialOfferJson = offerReq.CredentialOfferJson,
                //    CredentialRequestJson = credReq.CredentialRequestJson,
                //    CredentialValuesJson = ""
                //});

                Console.WriteLine($"Demo completed.");
            }
            finally
            {
                await Cleanup();
            }
        }

        async Task<T> Send<T>(IMessage message) where T : IMessage, new()
        {
            // Wrap the message into Any
            var wrapped = Any.Pack(message, "indy:agent:message");
            // Auth encrypt the entire payload
            var encrypted = await Crypto.AuthCryptAsync(wallet, myVk, agentVk, wrapped.ToByteArray());

            using (var client = new HttpClient())
            {
                var endpoint = await Did.GetEndpointForDidAsync(wallet, pool, agentDid);

                var request = new HttpRequestMessage();
                request.RequestUri = new Uri($"http://{endpoint.Address}");
                request.Method = HttpMethod.Post;

                // Prepare the final message, sign and load content
                var payload = new SecureMessage
                {
                    Content = ByteString.CopyFrom(encrypted),
                    Signature = ByteString.CopyFrom(await Crypto.SignAsync(wallet, myVk, encrypted)),
                    Type = MessageType.AuthCrypt
                };

                // Create content and set type to binary
                var content = new ByteArrayContent(payload.ToByteArray());
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                request.Content = content;

                // Send the request to the agent
                var response = await client.SendAsync(request);

                // Throw if not successful
                response.EnsureSuccessStatusCode();

                // Parse response message
                var responseSecure = new SecureMessage();
                responseSecure.MergeFrom(await response.Content.ReadAsByteArrayAsync());

                // Verify the response signature
                if (!await Crypto.VerifyAsync(agentVk, responseSecure.Content.ToByteArray(), responseSecure.Signature.ToByteArray()))
                {
                    throw new Exception("Invalid signature in response message");
                }

                // Auth decrypt the message
                var decrypted = await Crypto.AuthDecryptAsync(wallet, myVk, responseSecure.Content.ToByteArray());
                var anyResponse = new Any();
                anyResponse.MergeFrom(decrypted.MessageData);

                // Create the message object
                var result = new T();
                result.MergeFrom(anyResponse.Value);

                return result;
            }
        }
    }
}