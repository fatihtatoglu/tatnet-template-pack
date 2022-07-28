namespace Company.Application1
{
    using System;

    using Company.Application1.Extensions;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public static class Program
    {
        private static IConfigurationRoot configuration;

        public static void Main(string[] args)
        {
            configuration = CreateConfiguration();

            IHostBuilder builder = CreateHostBuilder(args);
            IHost host = builder.Build();

            host.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder builder = Host.CreateDefaultBuilder(args);
            builder.ConfigureServices(services =>
            {
                services
                    .AddHostedService<Worker>()
                    .AddOptions(configuration)
                    .EnableLogging(configuration);
            });

            return builder;
        }

        private static IConfigurationRoot CreateConfiguration()
        {
            string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{environmentName}.json", false, true)
                .AddEnvironmentVariables();

            return configurationBuilder.Build();
        }
    }
}