using System;
using Xunit;
using Indy.Agent.Messages;
using Google.Protobuf.WellKnownTypes;

namespace AgentFramework.Messages.Tests
{
    public class SerializationTests
    {
        [Fact]
		public void PackAndUnpack_Success()
        {
			var request = new ConnectionOfferResponse { Nonce = Guid.NewGuid().ToString() };
			var msg = new SignedMessage
			{
				Content = Any.Pack(request)
			};

			var result = msg.Content.TryUnpack<ConnectionOfferResponse>(out var unpacked);

			Assert.True(result);
			Assert.NotNull(unpacked);
			Assert.Equal(request.Nonce, unpacked.Nonce);
        }

		[Fact]
        public void PackAndUnpack_Fail()
        {
            var request = new ConnectionOfferResponse();
            var msg = new SignedMessage
            {
                Content = Any.Pack(request)
            };

			var result = msg.Content.TryUnpack<CredentialOfferResponse>(out var unpacked);

			Assert.False(result);
			Assert.Null(unpacked);
        }
    }
}
