using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using Azure.Identity;
using Play.Common.Settings;

namespace Play.Common.Configuration
{
    public static class Extensions
    {
        public static IHostBuilder ConfigureAzureKeyVault(this IHostBuilder builder)
        {
            return builder.ConfigureAppConfiguration((context, configurationBuilder) =>
                {
                    var configuration = configurationBuilder.Build();
                    var serviceSettings = configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();

                    if (context.HostingEnvironment.IsProduction())
                    {
                        configurationBuilder.AddAzureKeyVault(
                            new Uri($"https://{serviceSettings.KeyVaultName}.vault.azure.net/"),
                            new DefaultAzureCredential()
                        );
                    }
                });
        }
    }
}