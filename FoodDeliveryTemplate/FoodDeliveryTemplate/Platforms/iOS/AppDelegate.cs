﻿using Foundation;
using UIKit;

namespace FoodDeliveryTemplate;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp()
    {

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("EntryCustomization", (hander, view) =>
        {
#if IOS
            hander.PlatformView.BorderStyle = UITextBorderStyle.None;
#endif
        });

        return MauiProgram.CreateMauiApp();
    }
}
