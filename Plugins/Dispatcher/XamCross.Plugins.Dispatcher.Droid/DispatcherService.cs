using System;
using System.Threading;

using Android.App;

namespace XamCross.Plugins.Dispatcher.Droid
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
            if (Application.SynchronizationContext == SynchronizationContext.Current)
            {
                action();
            }
            else
            {
                Application.SynchronizationContext.Post(x => action(), null);
            }
        }

        #endregion

        #region properties

        #endregion
    }
}