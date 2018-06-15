using System.Collections.Generic;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Handlers;
using Google.Protobuf.WellKnownTypes;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers
{
    /// <summary>
    /// Agent service.
    /// </summary>
	public interface IMessageHandler
    {
        /// <summary>
        /// Gets the handler collection supported by this processor instance
        /// </summary>
        /// <value>The handlers.</value>
		IHandler[] Handlers { get; }

        /// <summary>
        /// Processes the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="message">Message.</param>
        /// <param name="context">Context.</param>
        Task<Msg> ProcessMessage(Msg message, IdentityContext context);
    }
}
