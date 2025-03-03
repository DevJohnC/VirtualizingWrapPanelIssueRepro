// See https://aka.ms/new-console-template for more information

using AvalonaWrapPanelRepro;
using Avalonia;
using Avalonia.ReactiveUI;

AppBuilder.Configure<App>()
    .UsePlatformDetect()
    .LogToTrace()
    .UseReactiveUI()
    .StartWithClassicDesktopLifetime(args);