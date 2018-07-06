using System;
namespace AgentFramework.MessageHandlers.Domain
{
    /// <summary>
    /// Pairwise metadata.
    /// </summary>
    public class PairwiseMetadata
    {
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:AgentFramework.MessageHandlers.Domain.PairwiseMetadata"/> is trusted.
        /// </summary>
        /// <value><c>true</c> if trusted; otherwise, <c>false</c>.</value>
        public bool Trusted
        {
            get;
            set;
        }
    }
}
