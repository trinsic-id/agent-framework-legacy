using System;
using AgentFramework.MessageHandlers.Handlers;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;

namespace AgentFramework.MessageHandlers
{
    public static class Extensions
    {
		public static string TypeName(this Any any) => any.TypeUrl.TrimStart("types.googleapis.com/".ToCharArray());


		public static IHandler[] BuildIssuer(this Controller controller)
		{
			return new IHandler[]
			{
    			new ConnectionHandler(),
    			new RegistrarHandler(),
    			new CredentialHandler(),
				new SchemaHandler()
			};
		}

		public static IHandler[] BuildVerifier(this Controller controller)
        {
            return new IHandler[]
            {
				new VerifierHandler()
            };
        }

		public static IHandler[] BuildRouter(this Controller controller)
		{
			return new IHandler[]
			{
				new ConnectionHandler()
			};
		}
	}
}
