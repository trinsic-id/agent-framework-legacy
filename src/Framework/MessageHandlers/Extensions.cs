using System;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Handlers;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.CryptoApi;
using Indy.Agent.Messages;
using Microsoft.AspNetCore.Mvc;

namespace AgentFramework.MessageHandlers
{
    public static class Extensions
    {
		public static string TypeName(this Any any) => any.TypeUrl.TrimStart("types.googleapis.com/".ToCharArray());


		public static IHandler[] BuildIssuer(this Controller controller)
		{
			return new IHandler[]
			{
    			new ConnectionHandler(),
    			new RegistrarHandler(),
    			new CredentialHandler(),
				new SchemaHandler()
			};
		}

		public static IHandler[] BuildVerifier(this Controller controller)
        {
            return new IHandler[]
            {
				new VerifierHandler()
            };
        }

		public static IHandler[] BuildRouter(this Controller controller)
		{
			return new IHandler[]
			{
				new ConnectionHandler()
			};
		}

		public static async Task<IActionResult> AnonCryptResponse(this Controller controller, IdentityContext context, Any message)
		{
			var result = new SecureMessage
			{
				Content = ByteString.CopyFrom(await Crypto.AnonCryptAsync(context.TheirVk, message.ToByteArray()))
            };

			return controller.File(message.ToByteArray(), "application/octet-stream");
		}

		public static async Task<IActionResult> AuthCryptResponse(this Controller controller, IdentityContext context, Any message)
        {
            var result = new SecureMessage
            {
                Signature = ByteString.CopyFrom(await Crypto.SignAsync(context.Wallet, context.MyVk, message.ToByteArray())),
				Content = ByteString.CopyFrom(await Crypto.AuthCryptAsync(context.Wallet, context.MyVk, context.TheirVk, message.ToByteArray()))
            };

            return controller.File(message.ToByteArray(), "application/octet-stream");
        }

		public static async Task<IActionResult> SignedResponse(this Controller controller, IdentityContext context, Any message)
        {
			var result = new UnsecureMessage
            {
				Content = message,
				Signature = ByteString.CopyFrom(await Crypto.SignAsync(context.Wallet, context.MyVk, message.ToByteArray()))
            };

            return controller.File(message.ToByteArray(), "application/octet-stream");
        }
	}
}
