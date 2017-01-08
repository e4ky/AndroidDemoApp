using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidApp.DemoApp1
{
    [Activity(Label = "演示APP_01", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        public const string ClickCountExtra = "ClickCount";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            Button btnOpenActivity = FindViewById<Button>(Resource.Id.btnOpenActivity);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            btnOpenActivity.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Activity1));
                intent.PutExtra(ClickCountExtra, count);
                StartActivity(intent);
            };
        }

    }
}

