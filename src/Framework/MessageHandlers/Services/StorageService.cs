using System;
using System.Collections.Generic;
using AgentFramework.MessageHandlers.Services.Contracts;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services
{
    public class StorageService : IStorageService
    {
        readonly List<Msg> messageStore;

        public StorageService()
        {
            messageStore = new List<Msg>();
        }

        public void Add(Msg msg)
        {
            messageStore.Add(msg);
        }

        public Msg[] Get(Predicate<Msg> predicate)
        {
            var result = messageStore.FindAll(predicate);
            messageStore.RemoveAll(predicate);
            return result.ToArray();
        }
    }
}
