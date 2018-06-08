using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.LedgerApi;
using Indy.Agent.Messages;
using System;
using System.Threading.Tasks;

namespace AgentFramework.MessageHandlers.Handlers
{
    public class RegistrarHandler : IHandler
    {

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Any> HandleMessage(Any msg, IdentityContext context)
        {
            switch (msg.TypeName())
            {
                case nameof(NymCreateRequest):
                    {
                        var nymCreate = msg.Unpack<NymCreateRequest>();

                        var res = await NymCreate(nymCreate, context);
                        return Any.Pack(res, Constants.MessagePrefix);
                    }
            }
            throw new Exception($"Unsupported message type: {msg.TypeUrl}");
        }

        /// <summary>
        /// Agents the nym create.
        /// </summary>
        /// <returns>The nym create.</returns>
        /// <param name="nymCreate">Nym create.</param>
        /// <param name="context">Context.</param>
        async Task<NymCreateResponse> NymCreate(NymCreateRequest nymCreate, IdentityContext context)
        {
            var req = await Ledger.BuildNymRequestAsync(context.MyDid, nymCreate.Did, nymCreate.Verkey, null, null);
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, req);

            return new NymCreateResponse();
        }

        /// <summary>
        /// Gets the supported message types for this handler
        /// </summary>
        /// <returns>The message types.</returns>
        public string[] SupportedMessageTypes()
        {
            return new[]
            {
                nameof(NymCreateRequest)
            };
        }
    }
}