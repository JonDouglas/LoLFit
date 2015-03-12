using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ModernHttpClient;
using Splat;

namespace LoLFit.Droid
{
    [Application]
    public class App : Application
    {
        public App(IntPtr handle, JniHandleOwnership ownerShip)
            : base(handle, ownerShip)
        {
        }

        static App()
        {
            Locator.CurrentMutable.RegisterConstant(new NativeMessageHandler(), typeof(HttpMessageHandler));
        }

        public override void OnCreate()
        {
            // If OnCreate is overridden, the overridden c'tor will also be called.
            base.OnCreate();
        }
    }
}