using System;

using XamCross.Plugins.Contacts;

namespace XamCross.ViewModels
{
    public class ContactListViewModel : AbstractListViewModel<Contact>
    {
        #region constructors

        public ContactListViewModel()
            : base()
        {
        }

        #endregion

        #region fields

        #endregion

        #region methods

        #region protected

        protected async override void SelectionChanged(Contact entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}