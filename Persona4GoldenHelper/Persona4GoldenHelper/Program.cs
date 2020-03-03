using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Persona4GoldenHelper
{
    /// <summary>The main app entry point.</summary>
    public class Program
    {
        /// <summary>The main app entry point.</summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // configure web server
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}
