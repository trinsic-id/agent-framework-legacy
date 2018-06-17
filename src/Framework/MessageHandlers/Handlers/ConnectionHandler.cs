using System;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Handlers;
using AgentFramework.MessageHandlers.Services.Contracts;
using Google.Protobuf;
using Hyperledger.Indy.CryptoApi;
using Hyperledger.Indy.DidApi;
using Hyperledger.Indy.LedgerApi;
using Hyperledger.Indy.PairwiseApi;
using Indy.Agent.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Connection handler.
    /// </summary>
    public class ConnectionHandler : IHandler
    {
        readonly string[] messageTypes;
        readonly IStorageService storageService;
        readonly IRouterService routerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
        public ConnectionHandler(IStorageService storageService,
                                 IRouterService routerService,
                                 params string[] messageTypes)
        {
            this.routerService = routerService;
            this.storageService = storageService;
            this.messageTypes = messageTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MessageHandlers.Handlers.ConnectionHandler"/> class.
        /// </summary>
        public ConnectionHandler(IStorageService storageService,
                                 IRouterService routerService)
            : this(storageService, routerService,
                   SovrinMessages.CONNECTION_OFFER,
                   SovrinMessages.CONNECTION_REQUEST,
                   SovrinMessages.CONNECTION_RESPONSE,
                   SovrinMessages.CONNECTION_ACKONOWLEDGEMENT,
                   StreetcredMessages.SEND_NYM,
                   StreetcredMessages.CREATE_CONNECTION_OFFER)
        {
        }

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="message">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Msg> HandleMessage(Msg message, IdentityContext context)
        {
            switch (message.Type)
            {
                case SovrinMessages.CONNECTION_ACKONOWLEDGEMENT:
                    return await ConnectionAcknowledge(message, context);

                case SovrinMessages.CONNECTION_REQUEST:
                    return await ConnectionRequest(message, context);

                case SovrinMessages.CONNECTION_RESPONSE:
                    return await StoreConnectionResponse(message, context);

                case StreetcredMessages.SEND_NYM:
                    return await SendNym(message, context);

                case StreetcredMessages.CREATE_CONNECTION_OFFER:
                    return await CreateConnectionOffer(context);
            }
            throw new Exception("Unsupported message exception");
        }

        /// <summary>
        /// Stores a connection response
        /// </summary>
        /// <returns>The connection response.</returns>
        /// <param name="message">Message.</param>
        /// <param name="context">Context.</param>
        protected virtual async Task<Msg> StoreConnectionResponse(Msg message, IdentityContext context)
        {
            await Task.Yield();

            storageService.Add(message);

            return null;
        }

        /// <summary>
        /// Connections the create.
        /// </summary>
        /// <returns>The create.</returns>
        protected virtual async Task<Msg> ConnectionRequest(Msg message, IdentityContext context)
        {
            var request = new ConnectionRequest();
            request.MergeFrom(message.Content);

            string myDid;
            string myVk;

            if (await storageService.TryGetNonce(request.RequestNonce, out byte[] offerMessage))
            {
                var offer = new ConnectionOffer();
                offer.MergeFrom(offerMessage);

                myDid = offer.Did;
                myVk = offer.Verkey;
            }
            else
            {
                var my = await Did.CreateAndStoreMyDidAsync(context.Wallet, "{}");
                myDid = my.Did;
                myVk = my.VerKey;

                var nymRequest = await Ledger.BuildNymRequestAsync(context.MyPublicDid, my.Did, my.VerKey, null, null);
                var nymResponse = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyPublicDid, nymRequest);
            }

            var theirKey = await Did.KeyForDidAsync(context.Pool, context.Wallet, request.Did);
            await Did.StoreTheirDidAsync(context.Wallet, JsonConvert.SerializeObject(new { did = request.Did, verkey = theirKey }));
            await Pairwise.CreateAsync(context.Wallet, request.Did, myDid, null);

            Console.WriteLine($"Saving their did {request.Did} {theirKey}");

            // TODO: process Endpoint and EndpointDid

            var response = new ConnectionResponse
            {
                Did = myDid,
                Verkey = myVk,
                RequestNonce = request.RequestNonce
            };

            var res = new Msg
            {
                Id = request.RequestNonce,
                Type = SovrinMessages.CONNECTION_RESPONSE,
                Aud = request.Did,
                Origin = myDid,
                Content = ByteString.CopyFrom(await Crypto.AnonCryptAsync(theirKey, response.ToByteArray()))
            };
            await routerService.SendAsync(request.EndpointDid, res, context);

            return null;
        }

        /// <summary>
        /// Connections the send.
        /// </summary>
        /// <returns>The send.</returns>
        /// <param name="context">Context.</param>
        protected virtual async Task<Msg> ConnectionAcknowledge(Msg message, IdentityContext context)
        {
            var myDid = await Pairwise.GetAsync(context.Wallet, message.Origin);
            var myKey = await Did.KeyForLocalDidAsync(context.Wallet, JObject.Parse(myDid)["my_did"].ToObject<string>());

            var decrypted = await Crypto.AuthDecryptAsync(context.Wallet, myKey, message.Content.ToByteArray());

            var ack = new ConnectionAcknowledgement();
            ack.MergeFrom(decrypted.MessageData);

            Console.WriteLine($"Ackowleedgement message \"{ack.Message}\" from {message.Origin}");

            return null;
        }

        protected virtual async Task<Msg> SendNym(Msg message, IdentityContext context)
        {
            var nym = new SendNym();
            nym.MergeFrom(message.Content.ToByteArray());

            var req = await Ledger.BuildNymRequestAsync(context.MyPublicDid, nym.Did, nym.Verkey, null, null);
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyPublicDid, req);

            return null;
        }

        /// <summary>
        /// Creates a new connection offer.
        /// </summary>
        /// <returns>The connection offer.</returns>
        /// <param name="context">Context.</param>
        protected virtual async Task<Msg> CreateConnectionOffer(IdentityContext context)
        {
            // Generate new keypair
            var my = await Did.CreateAndStoreMyDidAsync(context.Wallet, "{}");

            // Send did to ledger
            var nymRequest = await Ledger.BuildNymRequestAsync(context.MyPublicDid, my.Did, my.VerKey, null, null);
            var nymResponse = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyPublicDid, nymRequest);

            // Retrieve endpoint for this agent
            var myEndpoint = await Did.GetEndpointForDidAsync(context.Wallet, context.Pool, context.MyPublicDid);

            var offer = new ConnectionOffer
            {
                Did = my.Did,
                Verkey = my.VerKey,
                OfferNonce = Guid.NewGuid().ToString().ToLowerInvariant(),
                Endpoint = myEndpoint.Address
            };

            await storageService.SetNonce(offer.OfferNonce, offer.ToByteArray());

            return new Msg
            {
                Id = offer.OfferNonce,
                Type = SovrinMessages.CONNECTION_OFFER,
                Content = offer.ToByteString()
            };
        }

        /// <summary>
        /// Returns the supported message types
        /// </summary>
        /// <returns>The message types.</returns>
        public string[] SupportedMessageTypes() => messageTypes;
    }
}