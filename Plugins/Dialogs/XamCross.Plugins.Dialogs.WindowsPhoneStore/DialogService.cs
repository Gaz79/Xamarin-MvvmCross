using System;

using Cirrious.CrossCore;

using XamCross.Plugins.Dispatcher;

namespace XamCross.Plugins.Dialogs.WindowsPhoneStore
{
    public class DialogService : AbstractDialogService
    {
        #region constructors

        public DialogService()
        {
            _dispatcher = Mvx.Resolve<IDispatcherService>();

            if (Guard.IsNull(_dispatcher))
            {
                throw new NullReferenceException("_dispatcher");
            }
        }

        #endregion

        #region fields

        private readonly IDispatcherService _dispatcher;

        #endregion

        #region methods

        public static IDialogService Create()
        {
            return new DialogService();
        }

        #endregion

        #region properties

        #endregion
    }
}