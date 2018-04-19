using System;
using System.Linq;
using System.Threading.Tasks;
using Hyperledger.Indy.AnonCredsApi;
using Hyperledger.Indy.LedgerApi;
using Newtonsoft.Json;

namespace Streetcred.AgentFramework.MessageHandlers.Handlers
{
    public class SchemaHandler : IHandler
    {
		readonly MessageType[] messageTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.SchemaHandler"/> class.
        /// </summary>
        /// <param name="messageTypes">Message types.</param>
		public SchemaHandler(params MessageType[] messageTypes)
		{
			this.messageTypes = messageTypes;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.SchemaHandler"/> class.
        /// </summary>
		public SchemaHandler() : this(MessageType.SchemaCreateRequest,
		                              MessageType.CredentialDefinitionCreateRequest)
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
                case MessageType.SchemaCreateRequest:
                    {
						var req = msg.Unwrap<SchemaCreateRequest>();

                        var res = await CreateSchema(req, context);
                        return res.Wrap(MessageType.SchemaCreateResponse);
                    }
				case MessageType.CredentialDefinitionCreateRequest:
                    {
						var req = msg.Unwrap<CredentialDefinitionCreateRequest>();

                        var res = await CreateCredentialDefinition(req, context);
                        return res.Wrap(MessageType.CredentialDefinitionCreateResponse);
                    }
            }
            throw new Exception("Unsupported message type");
        }

        /// <summary>
        /// Creates the schema.
        /// </summary>
        /// <returns>The schema.</returns>
        /// <param name="schemaCreate">Schema create.</param>
        /// <param name="context">Context.</param>
        async Task<SchemaCreateResponse> CreateSchema(SchemaCreateRequest schemaCreate, AgentContext context)
        {
            var attrNames = JsonConvert.SerializeObject(schemaCreate.AttributeNames.ToArray());

            var schema = await AnonCreds.IssuerCreateSchemaAsync(context.Did,
                                                                 schemaCreate.Name,
                                                                 schemaCreate.Version,
                                                                 attrNames);

            var req = await Ledger.BuildSchemaRequestAsync(context.Did, schema.SchemaJson);
            var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.Did, req);

            return new SchemaCreateResponse { SchemaId = schema.SchemaId };
        }

		/// <summary>
        /// Creates the credential definition.
        /// </summary>
        /// <returns>The credential definition.</returns>
        /// <param name="definitionCreate">Definition create.</param>
        /// <param name="context">Context.</param>
        async Task<CredentialDefinitionCreateResponse> CreateCredentialDefinition(CredentialDefinitionCreateRequest definitionCreate, AgentContext context)
        {
            var schemaReq = await Ledger.BuildGetSchemaRequestAsync(context.Did, definitionCreate.SchemaId);
            var schemaRes = await Ledger.SubmitRequestAsync(context.Pool, schemaReq);

            var schemaData = await Ledger.ParseGetSchemaResponseAsync(schemaRes);

            var config = "{\"support_revocation\":false}";
            var definition = await AnonCreds.IssuerCreateAndStoreCredentialDefAsync(context.Wallet,
                                                                                    context.Did,
                                                                                    schemaData.ObjectJson,
                                                                                    "Tag1",
                                                                                    "CL",
                                                                                    config);

            var defReq = await Ledger.BuildCredDefRequestAsync(context.Did, definition.CredDefJson);
            var defRes = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.Did, defReq);

            return new CredentialDefinitionCreateResponse { CredentialDefinitionId = definition.CredDefId };
        }

		/// <summary>
		/// Supporteds the message types.
		/// </summary>
		/// <returns>The message types.</returns>
		public MessageType[] SupportedMessageTypes() => messageTypes;
    }
}
