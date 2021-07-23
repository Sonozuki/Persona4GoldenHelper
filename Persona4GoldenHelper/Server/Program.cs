using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Persona4GoldenHelper.Server
{
    /// <summary>The application entry point.</summary>
    public class Program
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>The application entry point.</summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        /// <summary>Creates a host builder.</summary>
        /// <param name="args">The command-line arguments.</param>
        /// <returns>A host builder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
