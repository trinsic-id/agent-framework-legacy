using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgentFramework.MessageHandlers.Services;
using AgentFramework.MessageHandlers.Services.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Service.Controllers;
using Service.Formatters;
using Service.Services;

namespace Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = services.AddMvc(options =>
            {
                options.InputFormatters.Insert(0, new RawRequestBodyFormatter());
            });

            services.AddSingleton<InitializationService>();
            services.AddSingleton<IRouterService, RouterService>();
            services.AddSingleton<IStorageService, StorageService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            // Initalize agent wallet
            var initService = app.ApplicationServices.GetService<InitializationService>();
            Task.WhenAll(initService.RunAgentInitialization());
        }
    }
}