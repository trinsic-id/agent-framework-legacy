using System;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers;

namespace AgentFramework.AspNetCore.Extensions.Services
{
    public interface IContextService
    {
        Task RunStartupInitialization();

        Task<IdentityContext> GetContext(object state);
    }
}
