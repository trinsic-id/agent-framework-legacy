using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Client
{
    class Program
    {
        public static IConfiguration Configuration { get; set; }

        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == null
                || Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                builder = builder
                    .AddJsonFile("appsettings.Development.json");
            }

            Configuration = builder.Build();

            await Task.Delay(TimeSpan.FromSeconds(15));

            var example = new ClientExample();
            await example.Execute();
        }
    }
}