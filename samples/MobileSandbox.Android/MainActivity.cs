﻿using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace MobileSandbox.Android
{
    [Activity(Label = "MobileSandbox.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : AvaloniaMainActivity<App>
    {
    }
}
