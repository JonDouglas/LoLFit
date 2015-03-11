using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using LoLFit.Core;
using LoLFit.Core.Model.Enum;

namespace LoLFit.Droid
{
    [Activity(Label = "LoLFit.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            LoLFitApi a = new LoLFitApi("TEST", Region.NA);
            var results = await a.GetMatchDetails(1752090973);
            var t = results.ToString();
        }
    }
}

