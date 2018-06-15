using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebExtensions
{
    public class AgentMiddleware
    {
        readonly RequestDelegate _next;

        public AgentMiddleware(RequestDelegate next)
        {
        }

        public Task InvokeAsync(HttpContext context)
        {


            // Call the next delegate/middleware in the pipeline
            return this._next(context);
        }
    }
}
