using System;
using Google.Protobuf;

namespace Streetcred.AgentFramework.MessageHandlers
{
    public static class Extensions
    {
        /// <summary>
        /// Unwrap the specified message.
        /// </summary>
        /// <returns>The unwrap.</returns>
        /// <param name="message">Message.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T Unwrap<T>(this Msg message)
            where T : IMessage, new()
        {
            var request = new T();
            request.MergeFrom(message.Content);
            return request;
        }

        /// <summary>
        /// Wrap the specified message and messageType.
        /// </summary>
        /// <returns>The wrap.</returns>
        /// <param name="message">Message.</param>
        /// <param name="messageType">Message type.</param>
        public static Msg Wrap(this IMessage message, MessageType messageType)
        {
            return new Msg
            {
                MessageType = messageType,
                Content = message.ToByteString()
            };
        }
    }
}
