using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.CurrentActivity;

namespace BarberApp.Droid
{
    [Activity(Label = "BarberApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            

            base.OnCreate(savedInstanceState);
                                                                        //...
            CrossCurrentActivity.Current.Init(activity: this, savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState); // add this line to your code, it may also be called: bundle
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            //...
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}