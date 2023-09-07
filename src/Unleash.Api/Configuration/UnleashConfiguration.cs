using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Unleash.Api.Configuration;

public static class UnleashConfiguration
{
    public static void ConfigureUnleash(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<UnleashClientSettings>(configuration);
        var settings = configuration.GetRequiredSection(nameof(UnleashClientSettings)).Get<UnleashClientSettings>();
        Guard.Against.Null(settings);
        Guard.Against.NullOrWhiteSpace(settings.BaseAddress);
        Guard.Against.NullOrWhiteSpace(settings.AuthToken);

        var unleashSettings = new UnleashSettings
        {
            AppName = settings.ApplicationName,
            UnleashApi = new Uri(settings.BaseAddress),
            CustomHttpHeaders = new Dictionary<string, string> { { "Authorization", settings.AuthToken } }
        };

        services.AddSingleton<IUnleash>(_ => new DefaultUnleash(unleashSettings));
    }
}
