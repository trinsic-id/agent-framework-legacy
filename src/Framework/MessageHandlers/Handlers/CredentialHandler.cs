using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.AnonCredsApi;
using Indy.Agent.Messages;
using System;
using System.Threading.Tasks;

namespace AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Issuer handler.
    /// </summary>
    public class CredentialHandler : IHandler
    {
		readonly string[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.CredentialHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
		public CredentialHandler(params string[] messageTypes)
		{
			this.messageTypes = messageTypes;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.CredentialHandler"/> class.
        /// </summary>
		public CredentialHandler() : this(nameof(CredentialOfferRequest),
		                                  nameof(CredentialRequest))
		{
		}

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        public async Task<Any> HandleMessage(Any msg, IdentityContext context)
        {
			switch (msg.TypeName())
            {
				case nameof(CredentialOfferRequest):
                    {
						var offerRequest = msg.Unpack<CredentialOfferRequest>();
						return Any.Pack(await CredentialOffer(offerRequest, context));
                    }
				case nameof(CredentialRequest):
                    {
						var credentialRequest = msg.Unpack<CredentialRequest>();
						return Any.Pack(await Credential(credentialRequest, context));
                    }
            }
			throw new Exception($"Unsupported message type: {msg.TypeUrl}");
        }

		/// <summary>
		/// Supporteds the message types.
		/// </summary>
		/// <returns>The message types.</returns>
		public string[] SupportedMessageTypes() => messageTypes;

        /// <summary>
        /// Credentials the offer.
        /// </summary>
        /// <returns>The offer.</returns>
        /// <param name="offerRequest">Offer request.</param>
        /// <param name="context">Context.</param>
        async Task<CredentialOfferResponse> CredentialOffer(CredentialOfferRequest offerRequest, IdentityContext context)
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
        async Task<CredentialResponse> Credential(CredentialRequest credentialRequest, IdentityContext context)
        {
            var req = await AnonCreds.IssuerCreateCredentialAsync(context.Wallet,
                                                                  credentialRequest.CredentialOfferJson,
                                                                  credentialRequest.CredentialRequestJson,
                                                                  credentialRequest.CredentialValuesJson,
                                                                  null,
                                                                  null);

            return new CredentialResponse { };
        }
    }
}
