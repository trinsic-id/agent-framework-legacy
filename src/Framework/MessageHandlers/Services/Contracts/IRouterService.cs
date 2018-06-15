using System;
using System.Threading.Tasks;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services.Contracts
{
    public interface IRouterService
    {
        Task SendAsync(string did, Msg message, IdentityContext context);
    }
}
