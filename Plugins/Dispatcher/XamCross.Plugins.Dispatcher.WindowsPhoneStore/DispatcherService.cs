using System;

using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace XamCross.Plugins.Dispatcher.WindowsPhoneStore
{
    public class DispatcherService : AbstractDispatcherService
    {
        #region constructors

        #endregion

        #region fields

        #endregion

        #region methods

        public static IDispatcherService Create()
        {
            return new DispatcherService();
        }

        public override void InvokeUI(Action action)
        {
            CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => action());
        }

        #endregion

        #region properties

        #endregion
    }
}