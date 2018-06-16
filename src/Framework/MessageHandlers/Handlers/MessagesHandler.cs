using System;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Services.Contracts;
using Google.Protobuf;
using Hyperledger.Indy.DidApi;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Handlers
{
    public class MessagesHandler : IHandler
    {
        readonly string[] messageTypes;
        readonly IStorageService storageService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
        public MessagesHandler(IStorageService storageService, params string[] messageTypes)
        {
            this.storageService = storageService;
            this.messageTypes = messageTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        public MessagesHandler(IStorageService storageService) : this(storageService, StreetcredMessages.GET_MESSAGES)
        {
        }

        public async Task<Msg> HandleMessage(Msg msg, IdentityContext context)
        {
            switch (msg.Type)
            {
                case StreetcredMessages.GET_MESSAGES:
                    return await GetMessages(msg, context);
            }
            throw new Exception($"Unsupported message: {msg.Type}");
        }

        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <returns>The messages.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        protected Task<Msg> GetMessages(Msg msg, IdentityContext context)
        {
            var result = new GetMessagesResponse();
            result.Messages.AddRange(storageService.Get(x => x.Aud == msg.Origin));

            return Task.FromResult(new Msg
            {
                Id = msg.Id,
                Type = StreetcredMessages.GET_MESSAGES_RESPONSE,
                Content = result.ToByteString()
            });
        }

        public string[] SupportedMessageTypes() => messageTypes;
    }
}
