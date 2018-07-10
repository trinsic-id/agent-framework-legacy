using System;
namespace AgentFramework.MessageHandlers
{
    public class Constants
    {
        public const string MessagePrefix = "indy:agent:message";
    }

    public class SovrinMessages
    {
        public const string CONNECTION_OFFER = "urn:sovrin:agent:message_type:sovrin.org/connection_offer";
        public const string CONNECTION_REQUEST = "urn:sovrin:agent:message_type:sovrin.org/connection_request";
        public const string CONNECTION_RESPONSE = "urn:sovrin:agent:message_type:sovrin.org/connection_response";
        public const string CONNECTION_ACKONOWLEDGEMENT = "urn:sovrin:agent:message_type:sovrin.org/connection_acknowledgement";

        public const string CREDENTIAL_OFFER = "urn:sovrin:agent:message_type:sovrin.org/credential_offer";
        public const string CREDENTIAL_REQUEST = "urn:sovrin:agent:message_type:sovrin.org/credential_request";
        public const string CREDENTIAL = "urn:sovrin:agent:message_type:sovrin.org/credential";

        public const string PROOF_REQUEST = "urn:sovrin:agent:message_type:sovrin.org/proof_request";
        public const string PROOF = "urn:sovrin:agent:message_type:sovrin.org/proof";
    }

    public class StreetcredMessages
    {
        public const string CREATE_CONNECTION_OFFER = "urn:sovrin:agent:message_type:streetcred.nyc/create_connection_offer";
        public const string GET_MESSAGES = "urn:sovrin:agent:message_type:streetcred.nyc/get_messages";
        public const string GET_MESSAGES_RESPONSE = "urn:sovrin:agent:message_type:streetcred.nyc/get_messages_response";
    }
}
