using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Kicksharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://0.0.0.0:5000")
                .UseStartup<Kicksharp.Config.Startup>()
                .Build();

            host.Run();
        }
    }
}
