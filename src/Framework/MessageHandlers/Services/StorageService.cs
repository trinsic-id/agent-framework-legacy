using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Services.Contracts;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services
{
    public class StorageService : IStorageService
    {
        readonly List<Msg> messageStore;
        readonly Dictionary<string, byte[]> nonceStore;

        public StorageService()
        {
            messageStore = new List<Msg>();
            nonceStore = new Dictionary<string, byte[]>();
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

        public Task SetNonce(string nonce, byte[] message)
        {
            nonceStore.Add(nonce, message);
            return Task.CompletedTask;
        }

        public Task<bool> TryGetNonce(string nonce, out byte[] message)
        {
            message = null;
            if (nonceStore.ContainsKey(nonce))
            {
                message = nonceStore[nonce];
                nonceStore.Remove(nonce);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
