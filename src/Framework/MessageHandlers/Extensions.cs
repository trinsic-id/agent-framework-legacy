using System;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Handlers;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Hyperledger.Indy.CryptoApi;
using Indy.Agent.Messages;
using Microsoft.AspNetCore.Mvc;

namespace AgentFramework.MessageHandlers
{
    public static class Extensions
    {
        public static string TypeName(this Any any) => any.TypeUrl.TrimStart($"{Constants.MessagePrefix}/".ToCharArray());


        public static IHandler[] BuildIssuer(this Controller controller)
        {
            return new IHandler[]
            {

            };
        }

        public static IHandler[] BuildVerifier(this Controller controller)
        {
            return new IHandler[]
            {

            };
        }

        public static IHandler[] BuildRouter(this Controller controller)
        {
            return new IHandler[]
            {

            };
        }


    }
}