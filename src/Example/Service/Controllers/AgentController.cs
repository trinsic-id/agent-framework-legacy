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
			var message = new SecureMessage();
            message.MergeFrom(body);

            using (var context = await initializationService.GetAgentContext())
            {
				var innerMessage = new Any();

				switch (message.Type)
				{
					case MessageType.AnonCrypt:
						{
							innerMessage.MergeFrom(await Crypto.AnonDecryptAsync(context.Wallet, context.MyVk, body));
							var response = await ProcessMessage(innerMessage, context);

							return await this.SignedResponse(context, response);
						}
					case MessageType.AuthCrypt:
						{
							var decrypted = await Crypto.AuthDecryptAsync(context.Wallet, context.MyVk, body);
							innerMessage.MergeFrom(decrypted.MessageData);
							context.TheirVk = decrypted.TheirVk;

							if (!await Crypto.VerifyAsync(decrypted.TheirVk, message.Content.ToByteArray(), message.Signature.ToByteArray()))
							{
								throw new Exception("Invalid signature");
							}                     
							var response = await ProcessMessage(innerMessage, context);

							return await this.AuthCryptResponse(context, response);
						}
				}
            }
			throw new Exception($"Unsupported message type: {message.Type}");
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
