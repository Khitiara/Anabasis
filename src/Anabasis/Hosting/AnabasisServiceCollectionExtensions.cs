﻿using Anabasis.Platform.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Anabasis.Hosting;

public static class AnabasisServiceCollectionExtensions
{
    public static IServiceCollection AddAnabasisCore(this IServiceCollection services, string[] args) {
        services.TryAddSingleton(sp =>
            sp.GetRequiredService<IAnabasisPlatform>().Window ?? throw new InvalidOperationException());
        services.TryAddSingleton(sp =>
            sp.GetRequiredService<IAnabasisPlatform>().GraphicsDevice ?? throw new InvalidOperationException());
        return services;
    }
}