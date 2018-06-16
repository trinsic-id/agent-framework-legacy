using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers;
using Client.Utils;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy;
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

        const string agentDid = "Q56vyWuJa34ME57wkDTzC4";
        const string myPublicDid = "CC8o5M5KLdxkTCRKLxJggH";

        string myDid;
        string myVk;

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

            Console.WriteLine($"Wallet and pool opened: {pool} {wallet}");
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
                //agentVk = await Did.KeyForDidAsync(pool, wallet, agentDid);

                // Create My Did
                var createMyDidResult = await Did.CreateAndStoreMyDidAsync(wallet, "{}");
                myDid = createMyDidResult.Did;
                myVk = createMyDidResult.VerKey;

                Console.WriteLine($"Created new did: {myDid}");

                await pool.RefreshAsync();

                Console.WriteLine($"Registering did with ledger using cloud agent: {myPublicDid}");

                // Register did and vk with ledger using cloud agent
                await SendToCloudAgent(StreetcredMessages.SEND_NYM, new SendNym { Did = myDid });

                Console.WriteLine($"Sending connection requests to organization agent: {agentDid}");

                // Send a connection to request to organization
                var connectionRequest = new ConnectionRequest() { Did = myDid, EndpointDid = myPublicDid };
                await SendToOrganizationAgent(SovrinMessages.CONNECTION_REQUEST, connectionRequest.ToByteArray());

                Console.WriteLine("Fetching new messages from cloud agent");

                // Check my cloud for new messages
                var messages = await SendToCloudAgent(StreetcredMessages.GET_MESSAGES, new GetMessages());
                var getMessages = new GetMessagesResponse();
                getMessages.MergeFrom(messages.Content);

                foreach (var message in getMessages.Messages)
                {
                    Console.WriteLine($"Received message of type: {message.Type}");
                }

                Console.WriteLine($"Demo completed.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            finally
            {
                await Cleanup();
            }
        }

        async Task<Msg> SendToCloudAgent(string type, IMessage request)
        {
            var endpoint = await Did.GetEndpointForDidAsync(wallet, pool, myPublicDid);
            var cloudAgentVk = await Did.KeyForDidAsync(pool, wallet, myPublicDid);

            var msg = new Msg
            {
                Content = request.ToByteString(),
                Origin = myDid,
                Type = type
            };

            using (var client = new HttpClient())
            {
                var payload = await Crypto.AuthCryptAsync(wallet, myVk, cloudAgentVk, msg.ToByteArray());

                var content = new ByteArrayContent(payload);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                var req = new HttpRequestMessage();
                req.RequestUri = new Uri($"http://{endpoint.Address}/api");
                req.Method = HttpMethod.Post;
                req.Content = content;

                var response = await client.SendAsync(req);

                var responseData = await response.Content.ReadAsByteArrayAsync();
                if (responseData.Any())
                {
                    var decrypted = await Crypto.AuthDecryptAsync(wallet, myVk, responseData);
                    var responseMsg = new Msg();
                    responseMsg.MergeFrom(decrypted.MessageData);

                    return responseMsg;
                }
                return null;
            }
        }

        async Task SendToOrganizationAgent(string type, byte[] request)
        {
            var endpoint = await Did.GetEndpointForDidAsync(wallet, pool, agentDid);
            var cloudAgentVk = await Did.KeyForDidAsync(pool, wallet, agentDid);

            var msg = new Msg();
            msg.Content = ByteString.CopyFrom(request);
            msg.Origin = myDid;
            msg.Type = type;

            using (var client = new HttpClient())
            {
                var payload = await Crypto.AnonCryptAsync(cloudAgentVk, msg.ToByteArray());

                var content = new ByteArrayContent(payload);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                var req = new HttpRequestMessage();
                req.RequestUri = new Uri($"http://{endpoint.Address}/");
                req.Method = HttpMethod.Post;
                req.Content = content;

                var response = await client.SendAsync(req);
            }
        }
    }
}