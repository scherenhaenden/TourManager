using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;



namespace TourManagerChromly
{
    public class CustomDisplayHandler : Xilium.CefGlue.CefDisplayHandler
    {
    }
    
    public class DemoChromelyApp : ChromelyBasicApp
    {
        public override void ConfigureServices(ServiceCollection services)
        {
            base.ConfigureServices(services);
            //services.AddLogging(configure => configure.AddConsole());
            //services.AddLogging(configure => configure.AddFile("Logs/serilog-{Date}.txt"));

            services.AddSingleton<Xilium.CefGlue.CefDisplayHandler, CustomDisplayHandler>();

            /*
            // Optional - adding custom handler
            services.AddSingleton<CefDragHandler, CustomDragHandler>();
            */

            /*
            // Optional- using config section to register IChromelyConfiguration
            // This just shows how it can be used, developers can use custom classes to override this approach
            //
            var builder = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var config = DefaultConfiguration.CreateFromConfigSection(configuration);
            services.AddSingleton<IChromelyConfiguration>(config);
            */

            /* Optional
            var options = new JsonSerializerOptions();
            options.ReadCommentHandling = JsonCommentHandling.Skip;
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.AllowTrailingCommas = true;
            services.AddSingleton<JsonSerializerOptions>(options);
            */

            RegisterControllerAssembly(services, typeof(DemoChromelyApp).Assembly);
        }
    }
}