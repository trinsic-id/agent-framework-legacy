using Hyperledger.Indy.AnonCredsApi;
using System;
using System.Threading.Tasks;

namespace Streetcred.AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Issuer handler.
    /// </summary>
    public class CredentialHandler : IHandler
    {
		readonly MessageType[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.CredentialHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
		public CredentialHandler(params MessageType[] messageTypes)
		{
			this.messageTypes = messageTypes;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.CredentialHandler"/> class.
        /// </summary>
		public CredentialHandler() : this(MessageType.CredentialOfferRequest,
		                                  MessageType.CredentialRequest)
		{
		}

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Msg> HandleMessage(Msg msg, AgentContext context, RequestContext requestContext)
        {
            switch (msg.MessageType)
            {
                case MessageType.CredentialOfferRequest:
                    {
                        var offerRequest = msg.Unwrap<CredentialOfferRequest>();

                        var res = await CredentialOffer(offerRequest, context);
                        return res.Wrap(MessageType.CredentialOfferResponse);
                    }

                case MessageType.CredentialRequest:
                    {
                        var credentialRequest = msg.Unwrap<CredentialRequest>();

                        var res = await Credential(credentialRequest, context);
                        return res.Wrap(MessageType.CredentialResponse);
                    }
            }
			throw new Exception($"Unsupported message type: {msg.MessageType}");
        }

		/// <summary>
		/// Supporteds the message types.
		/// </summary>
		/// <returns>The message types.</returns>
		public MessageType[] SupportedMessageTypes() => messageTypes;

        /// <summary>
        /// Credentials the offer.
        /// </summary>
        /// <returns>The offer.</returns>
        /// <param name="offerRequest">Offer request.</param>
        /// <param name="context">Context.</param>
        async Task<CredentialOfferResponse> CredentialOffer(CredentialOfferRequest offerRequest, AgentContext context)
        {
            var req = await AnonCreds.IssuerCreateCredentialOfferAsync(context.Wallet, offerRequest.CredentialDefinitionId);

            return new CredentialOfferResponse { CredentialOfferJson = req };
        }

        /// <summary>
        /// Credential the specified credentialRequest and context.
        /// </summary>
        /// <returns>The credential.</returns>
        /// <param name="credentialRequest">Credential request.</param>
        /// <param name="context">Context.</param>
        async Task<CredentialResponse> Credential(CredentialRequest credentialRequest, AgentContext context)
        {
            var req = await AnonCreds.IssuerCreateCredentialAsync(context.Wallet,
                                                                  credentialRequest.CredentialOfferJson,
                                                                  credentialRequest.CredentialRequestJson,
                                                                  credentialRequest.CredentialValuesJson,
                                                                  null,
                                                                  null);

            return new CredentialResponse { CredentialJson = req.CredentialJson };
        }
    }
}
