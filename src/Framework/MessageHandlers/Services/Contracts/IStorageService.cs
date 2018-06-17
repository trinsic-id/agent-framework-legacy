using System;
using System.Threading.Tasks;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services.Contracts
{
    public interface IStorageService
    {
        void Add(Msg msg);

        Msg[] Get(Predicate<Msg> predicate);

        Task SetNonce(string nonce, byte[] message);

        Task<bool> TryGetNonce(string nonce, out byte[] message);
    }
}
