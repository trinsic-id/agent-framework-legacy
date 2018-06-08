using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.LedgerApi;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Connection handler.
    /// </summary>
    public class ConnectionHandler : IHandler
    {
        readonly string[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
        public ConnectionHandler(params string[] messageTypes)
        {
            this.messageTypes = messageTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        public ConnectionHandler() : this(nameof(ConnectionOfferRequest),
                                          nameof(ConnectionRequest))
        {
        }

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="message">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Any> HandleMessage(Any message, IdentityContext context)
        {
            switch (message.TypeName())
            {
                case nameof(ConnectionOfferRequest):
                    {
                        return Any.Pack(await ConnectionOffer(context), Constants.MessagePrefix);
                    }
                case nameof(ConnectionRequest):
                    {
                        var connectionCreate = message.Unpack<ConnectionRequest>();
                        return Any.Pack(await ConnectionCreate(connectionCreate, context), Constants.MessagePrefix);
                    }
            }
            throw new Exception($"Unsupported message type: {message.TypeUrl}");
        }


        /// <summary>
        /// Connections the create.
        /// </summary>
        /// <returns>The create.</returns>
        protected virtual async Task<ConnectionResponse> ConnectionCreate(ConnectionRequest request, IdentityContext context)
        {
            var req = await Ledger.BuildNymRequestAsync(context.MyDid, request.Did, context.TheirVk, null, null);
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, req);

            return new ConnectionResponse();
        }

        /// <summary>
        /// Connections the send.
        /// </summary>
        /// <returns>The send.</returns>
        /// <param name="context">Context.</param>
        protected virtual Task<ConnectionOfferResponse> ConnectionOffer(IdentityContext context)
        {
            return Task.FromResult(new ConnectionOfferResponse { Nonce = Guid.NewGuid().ToString().ToLowerInvariant() });
        }

        /// <summary>
        /// Returns the supported message types
        /// </summary>
        /// <returns>The message types.</returns>
        public string[] SupportedMessageTypes() => messageTypes;
    }
}