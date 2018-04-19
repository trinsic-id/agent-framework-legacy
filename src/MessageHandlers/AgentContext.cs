﻿using System;
using System.Threading.Tasks;
using Hyperledger.Indy.PoolApi;
using Hyperledger.Indy.WalletApi;

namespace Streetcred.AgentFramework.MessageHandlers
{
    /// <summary>
    /// Agent context.
    /// </summary>
    public class AgentContext : IDisposable
    {
        /// <summary>
        /// Gets or sets the pool.
        /// </summary>
        /// <value>The pool.</value>
        public Pool Pool
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the wallet.
        /// </summary>
        /// <value>The wallet.</value>
        public Wallet Wallet
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        /// <value>The did.</value>
        public string Did
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ver key.
        /// </summary>
        /// <value>The ver key.</value>
        public string VerKey
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pub key.
        /// </summary>
        /// <value>The pub key.</value>
        public string PubKey
        {
            get;
            set;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Task.WhenAll(Wallet.CloseAsync(), Pool.CloseAsync());
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~AgentContext() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}