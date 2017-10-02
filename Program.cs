using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();

            var host = new WebHostBuilder()
                           .UseKestrel()
                           .UseStartup<Startup>()
                           .UseConfiguration(config)
                           .UseUrls("http://0.0.0.0:5000")
                           .Build();

            host.Run();      
        }
    }
}
