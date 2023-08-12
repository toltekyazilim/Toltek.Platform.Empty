using Microsoft.AspNetCore;
using Serilog;

namespace Toltek.Platform.Empty
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ToltekLogger.CreateLogger();
            CreateWebHostBuilder(args)
                .Build()
                .Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog();
    }
}
