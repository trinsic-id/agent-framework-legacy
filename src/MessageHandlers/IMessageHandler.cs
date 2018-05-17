using System.Collections.Generic;
using System.Threading.Tasks;

namespace Streetcred.AgentFramework.MessageHandlers
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
		List<IHandler> Handlers
        {
            get;
        }

		/// <summary>
		/// Processes the message.
		/// </summary>
		/// <returns>The message.</returns>
		/// <param name="message">Message.</param>
		/// <param name="context">Context.</param>
		Task<Msg> ProcessMessage(Msg message, IdentityContext context);
		//{
        //    foreach (var agent in Handlers)
        //        if (agent.SupportedMessageTypes().Contains(message.MessageType))
        //            return await agent.HandleMessage(message, context, requestContext);
                
        //    throw new NotSupportedException($"Message type '{message.MessageType}' is not supported by this agent.");
        //}
    }
}
