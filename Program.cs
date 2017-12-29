﻿using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace hellobook
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                    .AddEnvironmentVariables()
                    .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseConfiguration(config)
                .UseUrls("http://localhost:5001")
                .Build();

            host.Run();
        }
    }
}
