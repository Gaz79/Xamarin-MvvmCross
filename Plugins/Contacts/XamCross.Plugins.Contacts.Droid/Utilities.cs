using System;

using Android.Content;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Droid.Platform;

namespace XamCross.Plugins.Contacts.Droid
{
    public static class Utilities
    {
        public static Context GetActivityContext()
        {
            return Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
        }
    }
}