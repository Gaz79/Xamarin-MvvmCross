using System;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace XamCross.Plugins.Dialogs.WindowsPhoneStore
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.LazyConstructAndRegisterSingleton<IDialogService>(DialogService.Create);
        }
    }
}