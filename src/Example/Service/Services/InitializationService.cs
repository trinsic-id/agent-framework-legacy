using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers;
using Hyperledger.Indy.DidApi;
using Hyperledger.Indy.LedgerApi;
using Hyperledger.Indy.PoolApi;
using Hyperledger.Indy.WalletApi;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Service.Services
{
    public class InitializationService
    {
        readonly IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.AgentFramework.Services.WalletService"/> class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public InitializationService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Initializes the wallet and pool.
        /// </summary>
        /// <returns>The wallet and pool.</returns>
        async Task InitializeWalletAndPool()
        {
            Console.WriteLine("Initializing agent wallet and pool config.");

            var walletName = configuration.GetSection("Agent:Wallet:Name").Get<string>();
            var seed = configuration.GetSection("Agent:Wallet:Seed").Get<string>();
            var poolName = configuration.GetSection("Agent:Pool:Name").Get<string>();

            try
            {
                var config = GetGenesisConfiguration();
                await Pool.CreatePoolLedgerConfigAsync(poolName, config);
            }
            catch (PoolLedgerConfigExistsException)
            {
                Debug.WriteLine("Configuration exists");
            }

            try
            {
                await Wallet.CreateWalletAsync(poolName, walletName, "default", null, null);

                var wallet = await Wallet.OpenWalletAsync(walletName, null, null);
                var agentDid = await Did.CreateAndStoreMyDidAsync(wallet, JsonConvert.SerializeObject(new { seed }));

                // Set custom attribute to locate the did later in case multiple did's are created
                await Did.SetDidMetadataAsync(wallet, agentDid.Did, JsonConvert.SerializeObject(new { agent_did = true }));

                await wallet.CloseAsync();
            }
            catch (WalletExistsException)
            {
                Debug.WriteLine("Wallet exists");
            }
        }

        /// <summary>
        /// Runs the agent initialization.
        /// </summary>
        /// <returns>The agent initialization.</returns>
        internal async Task RunAgentInitialization()
        {
            try
            {
                await InitializeWalletAndPool();
                await SendEndpointToLedger();
                await SendAttributesToLedger();

                Console.WriteLine("Agent initialization completed.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Initialization failed: {e}");
            }
        }

        /// <summary>
        /// Send custom agent info to the ledger.
        /// </summary>
        /// <returns>The attributes to ledger.</returns>
        async Task SendAttributesToLedger()
        {
            using (var context = await GetAgentContext())
            {
                var attribJson = JsonConvert.SerializeObject(new
                {
                    agentInfo = new
                    {
                        name = configuration.GetSection("Agent:Attributes:Name").Get<string>()
                    }
                });
                var req = await Ledger.BuildAttribRequestAsync(context.MyDid, context.MyDid, null, attribJson, null);
                var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, req);
            }
        }

        /// <summary>
        /// Sends the endpoint to ledger.
        /// </summary>
        /// <returns>The endpoint to ledger.</returns>
        async Task SendEndpointToLedger()
        {
            Console.WriteLine("Registering agent endpoint with ledger.");

            using (var context = await GetAgentContext())
            {
                var endpoint = Environment.GetEnvironmentVariable("AGENT_ENDPOINT")
                                          ?? throw new Exception("Envrionment variable 'AGENT_ENDPOINT' must be set. Example: '127.0.0.1:5000'");

                var endpointJson = JsonConvert.SerializeObject(new
                {
                    endpoint = new
                    {
                        pubkey = context.MyPubKey,
                        ha = endpoint
                    }
                });
                var req = await Ledger.BuildAttribRequestAsync(context.MyDid, context.MyDid, null, endpointJson, null);
                var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, req);
            }
        }


        /// <summary>
        /// Gets the configuration context.
        /// </summary>
        /// <returns>The configuration context.</returns>
        public async Task<IdentityContext> GetAgentContext()
        {
            var config = GetGenesisConfiguration();

            var walletName = configuration.GetSection("Agent:Wallet:Name").Get<string>();
            var poolName = configuration.GetSection("Agent:Pool:Name").Get<string>();

            var pool = await Pool.OpenPoolLedgerAsync(poolName, null);
            var wallet = await Wallet.OpenWalletAsync(walletName, null, null);
            var keys = JArray.Parse(await Did.ListMyDidsWithMetaAsync(wallet));

            foreach (var item in keys)
            {
                if (item["metadata"] != null)
                {
                    var meta = JObject.Parse(item["metadata"].ToObject<string>());
                    if (meta["agent_did"] != null && meta["agent_did"].ToObject<bool>())
                    {
                        var did = item["did"].ToObject<string>();
                        var verKey = item["verkey"].ToObject<string>();

                        return new IdentityContext
                        {
                            MyDid = did,
                            MyVk = verKey,
                            MyPubKey = verKey,
                            Pool = pool,
                            Wallet = wallet
                        };
                    }
                }
            }
            throw new Exception("Unable to initialize base configuration context");
        }

        /// <summary>
        /// Gets the genesis configuration.
        /// </summary>
        /// <returns>The genesis configuration.</returns>
        string GetGenesisConfiguration()
        {
            var genesisFile = new FileInfo(configuration.GetSection("Agent:GenesisFile").Get<string>());
            return $"{{\"genesis_txn\":\"{genesisFile.FullName}\"}}";
        }
    }
}