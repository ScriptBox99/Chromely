﻿public class OwinWindowSample : Window
{
    public OwinWindowSample(IChromelyNativeHost nativeHost,
                  IChromelyConfiguration config,
                  ChromelyHandlersResolver handlersResolver)
        : base(nativeHost, config, handlersResolver)
    {

        #region Events
        FrameLoadStart += DemoWindow_FrameLoadStart;
        FrameLoadEnd += DemoWindow_FrameLoadEnd;
        LoadingStateChanged += DemoWindow_LoadingStateChanged;
        ConsoleMessage += DemoWindow_ConsoleMessage;
        AddressChanged += DemoWindow_AddressChanged;
        #endregion Events

    }

    #region Events
    private void DemoWindow_AddressChanged(object sender, AddressChangedEventArgs e)
    {
        Console.WriteLine("AddressChanged event called.");
    }

    private void DemoWindow_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
    {
        Console.WriteLine("ConsoleMessage event called.");
    }

    private void DemoWindow_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
    {
        Console.WriteLine("LoadingStateChanged event called.");
    }

    private void DemoWindow_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
    {
        Console.WriteLine("FrameLoadStart event called.");
    }

    private void DemoWindow_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
    {
        Console.WriteLine("FrameLoadEnd event called.");
    }

    #endregion Events
}