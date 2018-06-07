using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers;
using AgentFramework.MessageHandlers.Handlers;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.CryptoApi;
using Indy.Agent.Messages;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace Service.Controllers
{
    [Route("/")]
    public class AgentController : Controller, IMessageHandler
    {
		readonly InitializationService initializationService;

		public AgentController(InitializationService initializationService)
		{
			Handlers = new List<IHandler>(this.BuildIssuer());
			this.initializationService = initializationService;
		}

		public List<IHandler> Handlers { get; }

		[HttpPost()]
        public async Task<IActionResult> Post([FromBody] byte[] body)
        {
            using (var context = await initializationService.GetAgentContext())
            {
                var decrypted = await Crypto.AuthDecryptAsync(context.Wallet, context.MyVk, body);

                var message = new SignedMessage();
                message.MergeFrom(body);

                if (!await Crypto.VerifyAsync(decrypted.TheirVk, message.Content.ToByteArray(), message.Signature.ToByteArray()))
                {
                    throw new Exception("Invalid signature");
                }

                context.TheirVk = decrypted.TheirVk;
                context.TheirDid = message.SignerDid;

                var response = await ProcessMessage(message.Content, context);

                var result = new SignedMessage();
                result.SignerDid = context.MyDid;
                result.Signature = ByteString.CopyFrom(await Crypto.SignAsync(context.Wallet, context.MyVk, response.ToByteArray()));

                return File(response.ToByteArray(), "application/octet-stream");
            }
        }

		public async Task<Any> ProcessMessage(Any message, IdentityContext context)
		{
			foreach (var handler in Handlers)
                if (handler.SupportedMessageTypes().Contains(message.TypeName()))
                    return await handler.HandleMessage(message, context);

            throw new NotSupportedException($"Message type '{message.TypeUrl}' is not supported by this agent endpoint.");
        
		}
	}
}
