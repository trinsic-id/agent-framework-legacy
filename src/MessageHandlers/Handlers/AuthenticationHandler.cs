using Google.Protobuf;
using Hyperledger.Indy.CryptoApi;
using System;
using System.Threading.Tasks;

namespace Streetcred.AgentFramework.MessageHandlers.Handlers
{
    /// <summary>
    /// Authentication handler.
    /// </summary>
    public class AuthenticationHandler : IHandler
    {
	    readonly MessageType[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.AgentFramework.Handlers.AuthenticationHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
		public AuthenticationHandler(params MessageType[] messageTypes)
		{
			this.messageTypes = messageTypes;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.AgentFramework.Handlers.AuthenticationHandler"/> class.
        /// </summary>
		public AuthenticationHandler() : this(MessageType.AuthenticationRequest, 
		                                      MessageType.AuthenticationChallengeRequest)
		{
			
		}

		/// <summary>
        /// Handles the message.
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="msg">Message.</param>
        /// <param name="context">Context.</param>
        ///    /// 
      
		public async Task<Msg> HandleMessage(Msg msg, IdentityContext context)
        {
			switch (msg.MessageType)
			{
				case MessageType.AuthenticationChallengeRequest:
					{
						var res = await AuthenticationChallenge(context);
						return res.Wrap(MessageType.AuthenticationChallengeResponse);
					}
				case MessageType.AuthenticationRequest:
					{
						var authRequest = msg.Unwrap<AuthenticationRequest>();

						var res = await Authenticate(authRequest, context);
						return res.Wrap(MessageType.AuthenticationResponse);
					}
			}

			throw new Exception($"Unsupported message type: {msg.MessageType}");
		}

        /// <summary>
        /// Authentications the challenge.
        /// </summary>
        /// <returns>The challenge.</returns>
        /// <param name="context">Context.</param>
		protected virtual async Task<AuthenticationChallengeResponse> AuthenticationChallenge(IdentityContext context)
		{
			var challenge = new AuthenticationChallengeResponse.Types.Challenge
			{
				Did = context.MyDid,
				Nonce = Guid.NewGuid().ToString().ToLowerInvariant()
			};
			var signature = await Crypto.SignAsync(context.Wallet, context.MyVk, challenge.ToByteArray());

			return new AuthenticationChallengeResponse { Challenge = challenge, Signature = ByteString.CopyFrom(signature) };
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
		public MessageType[] SupportedMessageTypes() => messageTypes;
	}
}
