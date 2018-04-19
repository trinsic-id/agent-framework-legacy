using Hyperledger.Indy.LedgerApi;
using System;
using System.Threading.Tasks;

namespace Streetcred.AgentFramework.MessageHandlers.Handlers
{
    public class RegistrarHandler : IHandler
    {
        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Msg> HandleMessage(Msg msg, AgentContext context, RequestContext requestContext)
        {
            switch (msg.MessageType)
            {
                case MessageType.AgentNymCreateRequest:
                    {
                        var nymCreate = msg.Unwrap<AgentNymCreateRequest>();

                        var res = await AgentNymCreate(nymCreate, context);
                        return res.Wrap(MessageType.AgentNymCreateResponse);
                    }
            }
            throw new Exception("Message type not supported.");
        }

        /// <summary>
        /// Agents the nym create.
        /// </summary>
        /// <returns>The nym create.</returns>
        /// <param name="nymCreate">Nym create.</param>
        /// <param name="context">Context.</param>
        async Task<AgentNymCreateResponse> AgentNymCreate(AgentNymCreateRequest nymCreate, AgentContext context)
        {
            var req = await Ledger.BuildNymRequestAsync(context.Did, nymCreate.Did, nymCreate.Verkey, null, "TRUST_ANCHOR");
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.Did, req);

            return new AgentNymCreateResponse { Status = Status.Ok };
        }

        /// <summary>
        /// Gets the supported message types for this handler
        /// </summary>
        /// <returns>The message types.</returns>
        public MessageType[] SupportedMessageTypes()
        {
            return new[]
            {
                MessageType.AgentNymCreateRequest
            };
        }
    }
}