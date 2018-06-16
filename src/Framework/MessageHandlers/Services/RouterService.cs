using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Services.Contracts;
using Google.Protobuf;
using Hyperledger.Indy.CryptoApi;
using Hyperledger.Indy.DidApi;
using Indy.Agent.Messages;

namespace AgentFramework.MessageHandlers.Services
{
    public class RouterService : IRouterService
    {
        readonly HttpClient httpClient;

        public RouterService()
        {
            httpClient = new HttpClient();
        }

        public async Task SendAsync(string did, Msg message, IdentityContext context)
        {
            var endpoint = await Did.GetEndpointForDidAsync(context.Wallet, context.Pool, did);
            var theirKey = await Did.KeyForDidAsync(context.Pool, context.Wallet, did);

            var encrypted = await Crypto.AnonCryptAsync(theirKey, message.ToByteArray());

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"http://{endpoint.Address}/"),
                Method = HttpMethod.Post,
                Content = new ByteArrayContent(encrypted)
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }
    }
}
