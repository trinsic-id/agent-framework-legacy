using System;
using System.Threading.Tasks;
using Client.Utils;
using Hyperledger.Indy.DidApi;
using Hyperledger.Indy.PoolApi;
using Hyperledger.Indy.WalletApi;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
		{
			var myWalletName = "myWallet";
            var theirWalletName = "theirWallet";

			try
			{
				// 1. Create ledger config from genesis txn file
				await PoolUtils.CreatePoolLedgerConfig();

				// 2. Create and Open My Wallet
				await WalletUtils.CreateWalletAsync(PoolUtils.DEFAULT_POOL_NAME, myWalletName, "default", null, null);

				//3. Open pool and wallets in using statements to ensure they are closed when finished.
				using (var pool = await Pool.OpenPoolLedgerAsync(PoolUtils.DEFAULT_POOL_NAME, "{}"))
				using (var myWallet = await Wallet.OpenWalletAsync(myWalletName, null, null))
				{
					//4. Create My Did
					var createMyDidResult = await Did.CreateAndStoreMyDidAsync(myWallet, "{}");
					var myDid = createMyDidResult.Did;
					var myVerkey = createMyDidResult.VerKey;

					await myWallet.CloseAsync();
					await pool.CloseAsync();
				}
			}
			finally
			{
				await WalletUtils.DeleteWalletAsync(myWalletName, null);
                await WalletUtils.DeleteWalletAsync(theirWalletName, null);
                await PoolUtils.DeletePoolLedgerConfigAsync(PoolUtils.DEFAULT_POOL_NAME);
			}
        }
    }
}
