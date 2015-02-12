using System;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace XamCross.Plugins.Settings
{
    public class PluginLoader : IMvxPluginLoader
    {
        public static PluginLoader Instance = new PluginLoader();

        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();

            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}