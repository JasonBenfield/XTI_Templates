﻿using XTI___APPNAME__AppApi.Home;

namespace XTI___APPNAME__AppApi;

internal static class HomeGroupExtensions
{
    public static void AddHomeGroupServices(this IServiceCollection services)
    {
        services.AddScoped<IndexAction>();
    }
}