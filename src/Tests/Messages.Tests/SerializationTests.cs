using System;
using Xunit;
using Indy.Agent.Messages;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace AgentFramework.Messages.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void PackAndUnpack_Success()
        {
            var request = new ConnectionOffer { OfferNonce = Guid.NewGuid().ToString() };
            var msg = new Msg
            {
                Content = request.ToByteString()
            };

            var result = new Any();
            result.MergeFrom(msg.Content);

            var unpackResult = result.TryUnpack<ConnectionOffer>(out var unpacked);

            Assert.True(unpackResult);
            Assert.NotNull(unpacked);
            Assert.Equal(request.OfferNonce, unpacked.OfferNonce);
        }

        [Fact]
        public void PackAndUnpack_Fail()
        {
            //var request = new ConnectionOfferResponse();
            //var msg = new SecureMessage
            //{
            //    Content = Any.Pack(request).ToByteString()
            //};

            //var result = new Any();
            //result.MergeFrom(msg.Content);

            //var unpackResult = result.TryUnpack<CredentialOfferResponse>(out var unpacked);

            //Assert.False(unpackResult);
            //Assert.Null(unpacked);
        }
    }
}