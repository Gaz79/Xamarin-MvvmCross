using System;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace XamCross.Plugins.Dispatcher.WindowsPhoneStore
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.LazyConstructAndRegisterSingleton<IDispatcherService>(DispatcherService.Create);
        }
    }
}