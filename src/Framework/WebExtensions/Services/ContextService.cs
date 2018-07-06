using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using AgentFramework.AspNetCore.Extensions.Configuration;
using AgentFramework.MessageHandlers;
using Hyperledger.Indy.DidApi;
using Hyperledger.Indy.LedgerApi;
using Hyperledger.Indy.PoolApi;
using Hyperledger.Indy.WalletApi;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AgentFramework.AspNetCore.Extensions.Services
{
    public class ContextService : IContextService, IDisposable
    {
        readonly AgentOptions options;

        Pool pool;
        Wallet wallet;

        public ContextService(IOptions<AgentOptions> agentOptions)
        {
            options = agentOptions.Value;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <returns>The context.</returns>
        /// <param name="state">State.</param>
        public async virtual Task<IdentityContext> GetContext(object state = null)
        {
            if (wallet == null) wallet = await Wallet.OpenWalletAsync(options.WalletOptions.WalletName, null, null);
            if (pool == null) pool = await Pool.OpenPoolLedgerAsync(options.PoolOptions.PoolName, null);

            var keys = JArray.Parse(await Did.ListMyDidsWithMetaAsync(wallet));

            foreach (var item in keys)
            {
                if (item["metadata"] != null && !string.IsNullOrWhiteSpace(item["metadata"].ToString()))
                {
                    var meta = JObject.Parse(item["metadata"].ToObject<string>());
                    if (meta["agent_did"] != null && meta["agent_did"].ToObject<bool>())
                    {
                        var did = item["did"].ToObject<string>();
                        var verKey = item["verkey"].ToObject<string>();

                        return new IdentityContext
                        {
                            MyPublicDid = did,
                            MyPublicVerkey = verKey,
                            Pool = pool,
                            Wallet = wallet
                        };
                    }
                }
            }
            throw new Exception("Unable to initialize base configuration context");
        }

        /// <summary>
        /// Runs the startup initialization.
        /// </summary>
        /// <returns>The startup initialization.</returns>
        public async virtual Task RunStartupInitialization()
        {
            try
            {
                var genesisFile = Path.Combine(Directory.GetCurrentDirectory(), options.GenesisFile);
                var poolConfig = JsonConvert.SerializeObject(new { genesis_txn = genesisFile });

                await Pool.CreatePoolLedgerConfigAsync(options.PoolOptions.PoolName, poolConfig);
            }
            catch (PoolLedgerConfigExistsException)
            {
                Debug.WriteLine("Configuration exists");
            }

            pool = await Pool.OpenPoolLedgerAsync(options.PoolOptions.PoolName, null);

            try
            {
                await Wallet.CreateWalletAsync(options.PoolOptions.PoolName, options.WalletOptions.WalletName, "default", null, null);
                wallet = await Wallet.OpenWalletAsync(options.WalletOptions.WalletName, null, null);
                var agentDid = await Did.CreateAndStoreMyDidAsync(wallet, JsonConvert.SerializeObject(new { seed = options.WalletOptions.AgentSeed }));

                // Set custom attribute to locate the did later in case multiple did's are created
                await Did.SetDidMetadataAsync(wallet, agentDid.Did, JsonConvert.SerializeObject(new { agent_did = true }));
            }
            catch (WalletExistsException)
            {
                Debug.WriteLine("Wallet exists");
                wallet = await Wallet.OpenWalletAsync(options.WalletOptions.WalletName, null, null);
            }
        }

        #region IDisposable Support
        bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Task.WhenAll(wallet.CloseAsync(), pool.CloseAsync());

                    wallet = null;
                    pool = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~ContextService()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
