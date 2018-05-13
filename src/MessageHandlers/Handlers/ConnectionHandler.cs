using System;
using System.Threading.Tasks;
using Hyperledger.Indy.LedgerApi;
using Streetcred.AgentFramework.MessageHandlers;
using Streetcred.AgentFramework.MessageHandlers.Handlers;

namespace Streetcred.AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Connection handler.
    /// </summary>
    public class ConnectionHandler : IHandler
    {
		readonly MessageType[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
		public ConnectionHandler(params MessageType[] messageTypes)
        {
			this.messageTypes = messageTypes;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
		public ConnectionHandler() : this(MessageType.ConnectionOfferRequest,
		                                  MessageType.ConnectionRequest)
		{
		}

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        /// <param name="requestContext">Request context.</param>
        public async Task<Msg> HandleMessage(Msg msg, AgentContext context, RequestContext requestContext)
        {
            switch (msg.MessageType)
            {
                case MessageType.ConnectionOfferRequest:
                    {
                        var res = await ConnectionOffer(context);
                        return res.Wrap(MessageType.ConnectionOfferResponse);
                    }
                case MessageType.ConnectionRequest:
                    {
                        var connectionCreate = msg.Unwrap<ConnectionCreateRequest>();

                        var res = await ConnectionCreate(connectionCreate, requestContext.Verkey, context);
                        return res.Wrap(MessageType.ConnectionResponse);
                    }
            }
            throw new Exception("Unsupported message type");
        }


        /// <summary>
        /// Connections the create.
        /// </summary>
        /// <returns>The create.</returns>
        protected virtual async Task<ConnectionCreateResponse> ConnectionCreate(ConnectionCreateRequest request, string verkey, AgentContext context)
        {
            var req = await Ledger.BuildNymRequestAsync(context.Did, request.Did, verkey, null, null);
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.Did, req);

            return new ConnectionCreateResponse { Status = ConnectionCreateResponse.Types.Status.Ok };
        }

        /// <summary>
        /// Connections the send.
        /// </summary>
        /// <returns>The send.</returns>
        /// <param name="context">Context.</param>
        protected virtual Task<ConnectionOfferResponse> ConnectionOffer(AgentContext context)
        {
            return Task.FromResult(new ConnectionOfferResponse { Nonce = Guid.NewGuid().ToString(), Did = context.Did });
        }

        /// <summary>
        /// Returns the supported message types
        /// </summary>
        /// <returns>The message types.</returns>
		public MessageType[] SupportedMessageTypes() => messageTypes;
    }
}
