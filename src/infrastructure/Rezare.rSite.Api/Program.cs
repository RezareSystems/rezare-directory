using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Rezare.rSite.Api
{
    /// <summary>
    /// Api starting point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program Main method.
        /// </summary>
        /// <param name="args">Unused args parameter.</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create Web Host Builder.
        /// </summary>
        /// <param name="args">Args parameter.</param>
        /// <returns>A concrete instance of IWebHostBuilder.</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
