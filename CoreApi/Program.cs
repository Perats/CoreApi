using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace CoreApi
{
    public class Program
    {
        public static NLog.Logger Logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
             .ConfigureLogging(logging =>
             {
                 logging.ClearProviders();
                 logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
             })
                .UseNLog()
                .UseStartup<Startup>();
    }
}
