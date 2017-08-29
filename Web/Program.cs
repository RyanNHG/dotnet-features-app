using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Kicksharp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var host = WebHost.CreateDefaultBuilder(args)
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseUrls("http://0.0.0.0:5000")
				.UseStartup<Config.Startup>()
				.Build();
            
            host.Run();
        }
    }
}
