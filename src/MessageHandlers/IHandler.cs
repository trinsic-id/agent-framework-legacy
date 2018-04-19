using System.Threading.Tasks;

namespace Streetcred.AgentFramework.MessageHandlers
{
    /// <summary>
    /// Message handler.
    /// </summary>
	public interface IHandler
    {
        /// <summary>
        /// Supporteds the message types.
        /// </summary>
        /// <returns>The message types.</returns>
        MessageType[] SupportedMessageTypes();

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        Task<Msg> HandleMessage(Msg msg, AgentContext context, RequestContext requestContext);
    }
}
