using System;
using System.Threading.Tasks;

namespace Streetcred.AgentFramework.MessageHandlers.Handlers
{
    public class VerifierHandler : IHandler
    {
        public Task<Msg> HandleMessage(Msg msg, AgentContext context, RequestContext requestContext)
        {
            throw new NotImplementedException();
        }

        public MessageType[] SupportedMessageTypes()
        {
			return new []
			{
				MessageType.ProofSendRequest,
				MessageType.ProofCreateRequest
			};
        }
    }
}
