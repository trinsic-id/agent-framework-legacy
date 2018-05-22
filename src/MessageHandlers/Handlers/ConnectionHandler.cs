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
        ///  

        public async Task<Msg> HandleMessage(Msg msg, IdentityContext context)
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
                        var connectionCreate = msg.Unwrap<ConnectionRequest>();

                        var res = await ConnectionCreate(connectionCreate, context);
                        return res.Wrap(MessageType.ConnectionResponse);
                    }
            }
            throw new Exception("Unsupported message type");
        }


        /// <summary>
        /// Connections the create.
        /// </summary>
        /// <returns>The create.</returns>
        protected virtual async Task<ConnectionResponse> ConnectionCreate(ConnectionRequest request, IdentityContext context)
        {
            var req = await Ledger.BuildNymRequestAsync(context.MyDid, context.TheirDid, context.TheirVk, null, null);
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, req);

            return new ConnectionResponse { Status = ConnectionResponse.Types.Status.Ok };
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
		public MessageType[] SupportedMessageTypes() => messageTypes;
    }
}
