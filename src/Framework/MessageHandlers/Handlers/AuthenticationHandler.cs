using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.CryptoApi;
using Indy.Agent.Messages;
using System;
using System.Threading.Tasks;

namespace AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Authentication handler.
    /// </summary>
    public class AuthenticationHandler : IHandler
    {
        readonly string[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.AgentFramework.Handlers.AuthenticationHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
		public AuthenticationHandler(params string[] messageTypes)
        {
            this.messageTypes = messageTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.AgentFramework.Handlers.AuthenticationHandler"/> class.
        /// </summary>
		public AuthenticationHandler() : this(nameof(AuthenticationRequest),
		                                      nameof(AuthenticationChallengeRequest))
        {

        }

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        ///    /// 
        public virtual async Task<Any> HandleMessage(Any msg, IdentityContext context)
        {
			switch (msg.TypeName())
            {
				case nameof(AuthenticationChallengeRequest):
                    {
						return Any.Pack(await AuthenticationChallenge(context));
                    }
				case nameof(AuthenticationRequest):
                    {
						var authRequest = msg.Unpack<AuthenticationRequest>();

						return Any.Pack(await Authenticate(authRequest, context));
                    }
            }
			throw new Exception($"Unsupported message type: {msg.TypeUrl}");
        }

        /// <summary>
        /// Authentications the challenge.
        /// </summary>
        /// <returns>The challenge.</returns>
        /// <param name="context">Context.</param>
		protected virtual Task<AuthenticationChallengeResponse> AuthenticationChallenge(IdentityContext context)
        {
			return Task.FromResult(new AuthenticationChallengeResponse
			{
				Nonce = Guid.NewGuid().ToString().ToLowerInvariant()
			});
        }

        /// <summary>
        /// Authenticate the specified authRequest, context and requestContext.
        /// </summary>
        /// <returns>The authenticate.</returns>
        /// <param name="authRequest">Auth request.</param>
        /// <param name="context">Context.</param>
        /// <param name="requestContext">Request context.</param>
        protected virtual Task<AuthenticationResponse> Authenticate(AuthenticationRequest authRequest, IdentityContext context)
        {
            // TODO: Generate and return Token
            return Task.FromResult(new AuthenticationResponse());
        }

        /// <summary>
        /// Supporteds the message types.
        /// </summary>
        /// <returns>The message types.</returns>
        public string[] SupportedMessageTypes() => messageTypes;
    }
}