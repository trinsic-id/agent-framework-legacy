using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.AnonCredsApi;
using Hyperledger.Indy.LedgerApi;
using Indy.Agent.Messages;
using Newtonsoft.Json;

namespace AgentFramework.MessageHandlers.Handlers
{
	public class SchemaHandler : IHandler
	{
		readonly string[] messageTypes;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.SchemaHandler"/> class.
		/// </summary>
		/// <param name="messageTypes">Message types.</param>
		public SchemaHandler(params string[] messageTypes)
		{
			this.messageTypes = messageTypes;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Streetcred.Agent.Agents.Handlers.SchemaHandler"/> class.
		/// </summary>
		public SchemaHandler() : this(nameof(SchemaCreateRequest),
									  nameof(CredentialDefinitionCreateRequest))
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
				case nameof(SchemaCreateRequest):
					{
						var req = msg.Unpack<SchemaCreateRequest>();
						return Any.Pack(await CreateSchema(req, context), Constants.MessagePrefix);
					}
				case nameof(CredentialDefinitionCreateRequest):
					{
						var req = msg.Unpack<CredentialDefinitionCreateRequest>();
						return Any.Pack(await CreateCredentialDefinition(req, context), Constants.MessagePrefix);
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
		async Task<SchemaCreateResponse> CreateSchema(SchemaCreateRequest schemaCreate, IdentityContext context)
		{
			var attrNames = JsonConvert.SerializeObject(schemaCreate.AttributeNames.ToArray());

			var schema = await AnonCreds.IssuerCreateSchemaAsync(context.MyDid,
																 schemaCreate.Name,
																 schemaCreate.Version,
																 attrNames);

			var req = await Ledger.BuildSchemaRequestAsync(context.MyDid, schema.SchemaJson);
			var res = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, req);

			return new SchemaCreateResponse { SchemaId = schema.SchemaId };
		}

		/// <summary>
		/// Creates the credential definition.
		/// </summary>
		/// <returns>The credential definition.</returns>
		/// <param name="definitionCreate">Definition create.</param>
		/// <param name="context">Context.</param>
		async Task<CredentialDefinitionCreateResponse> CreateCredentialDefinition(CredentialDefinitionCreateRequest definitionCreate, IdentityContext context)
		{
			var schemaReq = await Ledger.BuildGetSchemaRequestAsync(context.MyDid, definitionCreate.SchemaId);
			var schemaRes = await Ledger.SubmitRequestAsync(context.Pool, schemaReq);

			var schemaData = await Ledger.ParseGetSchemaResponseAsync(schemaRes);

			var config = "{\"support_revocation\":false}";
			var definition = await AnonCreds.IssuerCreateAndStoreCredentialDefAsync(context.Wallet,
																					context.MyDid,
																					schemaData.ObjectJson,
																					"Tag1",
																					"CL",
																					config);

			var defReq = await Ledger.BuildCredDefRequestAsync(context.MyDid, definition.CredDefJson);
			var defRes = await Ledger.SignAndSubmitRequestAsync(context.Pool, context.Wallet, context.MyDid, defReq);

			return new CredentialDefinitionCreateResponse { CredentialDefinitionId = definition.CredDefId };
		}

		/// <summary>
		/// Supporteds the message types.
		/// </summary>
		/// <returns>The message types.</returns>
		public string[] SupportedMessageTypes() => messageTypes;
	}
}