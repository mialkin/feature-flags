using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Unleash.Api.Configuration;

public static class UnleashConfiguration
{
    public static void ConfigureUnleash(this IServiceCollection services)
    {
        var settings = new UnleashSettings
        {
            AppName = "Default",
            UnleashApi = new Uri("http://localhost:3010/api"),
            CustomHttpHeaders = new Dictionary<string, string>
            {
                { "Authorization", "default:development.unleash-insecure-api-token" }
            }
        };

        services.AddSingleton<IUnleash>(_ => new DefaultUnleash(settings));
    }
}
