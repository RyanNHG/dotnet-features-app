using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace KickSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://*:5000")
                .UseIISIntegration()
                .UseStartup<KickSharp.Config.Startup>()
                .Build();

            host.Run();
        }
    }
}
