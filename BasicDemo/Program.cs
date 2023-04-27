using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BasicDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myenvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, builder) =>
                {
                    IHostEnvironment env = hostingContext.HostingEnvironment;
                    builder.Sources.Clear();


                    // need to exit and reset Visual Studio to pick up changes in environment variables;
                    var myenvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                    var xy = Environment.GetEnvironmentVariables();

                    builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    builder.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                    builder.AddEnvironmentVariables();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
