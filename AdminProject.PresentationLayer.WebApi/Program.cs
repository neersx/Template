using System.IO;
using System.Threading.Tasks;
using AdminProject.PresentationLayer.WebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DreamWedds.PresentationLayer.WebApi
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
             .ConfigureLogging(logging =>
                {
                    logging.SetMinimumLevel(LogLevel.Information);
                    logging.ClearProviders();
                    logging.AddConsole();
                })
             .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                var configFolder = Path.Combine(hostingContext.HostingEnvironment.ContentRootPath, "..", "Shared");
                config.AddJsonFile(Path.Combine(configFolder, "SharedSettings.json"), optional: true);
                config.AddXmlFile(Path.Combine(configFolder, "DictionaryEncryption.xml"), optional: true);
            });

    }
}
