﻿namespace XTI___APPNAME__WebAppApi.Home;

public sealed class HomeGroup : AppApiGroupWrapper
{
    public HomeGroup(AppApiGroup source, IServiceProvider sp)
        : base(source)
    {
        Index = source.AddAction(nameof(Index), () => sp.GetRequiredService<IndexAction>());
    }

    public AppApiAction<EmptyRequest, WebViewResult> Index { get; }
}