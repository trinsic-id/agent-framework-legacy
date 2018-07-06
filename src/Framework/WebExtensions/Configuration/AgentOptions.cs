using System;
namespace AgentFramework.AspNetCore.Extensions.Configuration
{
    /// <summary>
    /// Agent options.
    /// </summary>
    public class AgentOptions
    {
        /// <summary>
        /// Gets or sets the wallet options.
        /// </summary>
        /// <value>The wallet options.</value>
        public Wallet WalletOptions
        {
            get;
            set;

        }

        /// <summary>
        /// Gets or sets the pool options.
        /// </summary>
        /// <value>The pool options.</value>
        public Pool PoolOptions
        {
            get;
            set;

        }

        /// <summary>
        /// Gets or sets the genesis file.
        /// </summary>
        /// <value>The genesis file.</value>
        public string GenesisFile
        {
            get;
            set;
        }

        public string EndpointUri
        {
            get;
            set;
        } = "127.0.0.1:5000";

        /// <summary>
        /// Pool.
        /// </summary>
        public class Pool
        {
            /// <summary>
            /// Gets or sets the name of the pool.
            /// </summary>
            /// <value>The name of the pool.</value>
            public string PoolName
            {
                get;
                set;
            } = "DefaultPool";
        }

        /// <summary>
        /// Wallet.
        /// </summary>
        public class Wallet
        {
            /// <summary>
            /// Gets or sets the agent seed.
            /// </summary>
            /// <value>The agent seed.</value>
            public string AgentSeed
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets the name of the wallet.
            /// </summary>
            /// <value>The name of the wallet.</value>
            public string WalletName
            {
                get;
                set;
            } = "DefaultWallet";
        }
    }
}
