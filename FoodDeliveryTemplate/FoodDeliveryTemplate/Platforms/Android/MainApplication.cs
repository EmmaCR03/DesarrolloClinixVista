using Android.App;
using Android.Runtime;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace FoodDeliveryTemplate;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

    protected override MauiApp CreateMauiApp()
    {

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("EntryCustomization", (hander, view) =>
        {
#if ANDROID
            hander.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
        });

        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("EditorCustomization", (hander, view) =>
        {
#if ANDROID
            hander.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
        });

        return MauiProgram.CreateMauiApp();
    }
}
