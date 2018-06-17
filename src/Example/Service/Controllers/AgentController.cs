using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers;
using AgentFramework.MessageHandlers.Handlers;
using AgentFramework.MessageHandlers.Services.Contracts;
using Google.Protobuf;
using Hyperledger.Indy.CryptoApi;
using Hyperledger.Indy.DidApi;
using Indy.Agent.Messages;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace Service.Controllers
{
    public class AgentController : Controller, IMessageHandler
    {
        readonly InitializationService initializationService;
        readonly IRouterService routerService;
        readonly IStorageService storageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Service.Controllers.AgentController"/> class.
        /// </summary>
        /// <param name="initializationService">Initialization service.</param>
        public AgentController(InitializationService initializationService, IRouterService routerService, IStorageService storageService)
        {
            this.storageService = storageService;
            this.Handlers = new IHandler[]
            {
                new ConnectionHandler(storageService, routerService),
                new MessagesHandler(storageService)
            };

            this.initializationService = initializationService;
            this.routerService = routerService;
        }

        /// <summary>
        /// Gets the message handlers supported by this agent
        /// </summary>
        /// <value>The handlers.</value>
        public IHandler[] Handlers { get; }

        /// <summary>
        /// An endpoint for agent interaction
        /// </summary>
        /// <returns>The post.</returns>
        /// <param name="body">Body.</param>
        [HttpPost("/")]
        public async Task<IActionResult> Post([FromBody] byte[] body)
        {
            using (var context = await initializationService.GetAgentContext())
            {
                var msg = new Msg();
                msg.MergeFrom(await Crypto.AnonDecryptAsync(context.Wallet, context.MyPublicVerkey, body));

                await ProcessMessage(msg, context);
                return Ok();
            }
        }

        /// <summary>
        /// Post the specified body.
        /// </summary>
        /// <returns>The post.</returns>
        /// <param name="body">Body.</param>
        [HttpPost("api")]
        public async Task<IActionResult> PostApi([FromBody] byte[] body)
        {
            using (var context = await initializationService.GetAgentContext())
            {
                var decrypted = await Crypto.AuthDecryptAsync(context.Wallet, context.MyPublicVerkey, body);
                var theirVk = decrypted.TheirVk;

                var msg = new Msg();
                msg.MergeFrom(decrypted.MessageData);

                var response = await ProcessMessage(msg, context);
                if (response != null)
                {
                    var myVk = await Did.KeyForLocalDidAsync(context.Wallet, context.MyPublicDid);
                    var encrypted = await Crypto.AuthCryptAsync(context.Wallet, myVk, theirVk, response.ToByteArray());
                    return File(encrypted, "application/octet-stream");
                }
                return Ok();
            }
        }

        /// <summary>
        /// Processes the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="message">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Msg> ProcessMessage(Msg message, IdentityContext context)
        {
            Console.WriteLine($"Processing message of type: {message.Type}");

            foreach (var handler in Handlers)
                if (handler.SupportedMessageTypes().Contains(message.Type))
                    return await handler.HandleMessage(message, context);

            throw new Exception($"Unspported message type: {message.Type}");
        }
    }
}