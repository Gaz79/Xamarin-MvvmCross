using System;

using UIKit;

namespace XamCross.Plugins.Dispatcher.Touch
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
            UIApplication.SharedApplication.InvokeOnMainThread(action);
        }

        #endregion

        #region properties

        #endregion
    }
}