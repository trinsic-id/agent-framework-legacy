using System;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services.Contracts
{
    public interface IStorageService
    {
        void Add(Msg msg);

        Msg[] Get(Predicate<Msg> predicate);
    }
}
