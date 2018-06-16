using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Handlers
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
        string[] SupportedMessageTypes();

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        Task<Msg> HandleMessage(Msg msg, IdentityContext context);
    }
}