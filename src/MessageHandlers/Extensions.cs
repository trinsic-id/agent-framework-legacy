using System;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace AgentFramework.MessageHandlers
{
    public static class Extensions
    {
		public static string TypeName(this Any any) => any.TypeUrl.TrimStart("types.googleapis.com/".ToCharArray());
	}
}
