using System;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace XamCross.Plugins.Settings.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.LazyConstructAndRegisterSingleton<ISettingService>(SettingService.Create);
        }
    }
}