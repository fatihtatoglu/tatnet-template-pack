namespace Company.Application1.Extensions
{
    using System;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddOptions(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddOptions();

            // Add custom option mapping definition.

            return services;
        }

        public static IServiceCollection EnableLogging(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddLogging(x => x.AddConsole().SetMinimumLevel(LogLevel.Trace));

            IConfigurationSection loggingSection = configuration.GetSection("Logging");
            services.AddLogging(x => x.AddFile(loggingSection));

            return services;
        }
    }
}