using System;
namespace AgentFramework.MessageHandlers.Domain
{
    /// <summary>
    /// Did metadata.
    /// </summary>
    public class DidMetadata
    {
        /// <summary>
        /// Gets or sets the endpoint did used for transport encryption.
        /// </summary>
        /// <value>The endpoint did.</value>
        public string EndpointDid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the endpoint for this did.
        /// </summary>
        /// <value>The endpoint.</value>
        public string Endpoint
        {
            get;
            set;
        }
    }
}
