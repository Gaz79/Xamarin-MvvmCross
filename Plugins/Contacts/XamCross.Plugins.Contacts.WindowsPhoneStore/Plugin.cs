using System;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace XamCross.Plugins.Contacts.WindowsPhoneStore
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.LazyConstructAndRegisterSingleton<IContactService>(ContactService.Create);
        }
    }
}