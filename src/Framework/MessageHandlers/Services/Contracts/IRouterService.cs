using System;
using System.Threading.Tasks;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services.Contracts
{
    /// <summary>
    /// Router service.
    /// </summary>
    public interface IRouterService
    {
        /// <summary>
        /// Sends the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="agentPublicDid">Agent public did.</param>
        /// <param name="message">Message.</param>
        /// <param name="context">Context.</param>
        Task SendAsync(string agentPublicDid, Msg message, IdentityContext context);
    }
}
