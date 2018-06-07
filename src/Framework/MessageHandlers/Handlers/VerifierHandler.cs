using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Handlers
{
	public class VerifierHandler : IHandler
	{
		public Task<Any> HandleMessage(Any msg, IdentityContext contextt)
		{
			throw new NotImplementedException();
		}

		public string[] SupportedMessageTypes()
		{
			throw new NotImplementedException();
		}
	}
}