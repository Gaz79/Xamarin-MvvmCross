using System;

using XamCross.Plugins.Contacts;

namespace XamCross.ViewModels
{
    public class ContactListViewModel : AbstractListViewModel<Contact>
    {
        #region constructors

        public ContactListViewModel(IContactService contactService)
        {
            if (Guard.IsNull(contactService))
            {
                throw new ArgumentNullException("contactService");
            }

            _contactService = contactService;
        }

        #endregion

        #region fields

        private readonly IContactService _contactService;

        #endregion

        #region methods

        #region private

        private async void GetContacts()
        {
            try
            {
                Items = _contactService.GetContacts();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region protected

        protected async override void SelectionChanged(Contact entity)
        {
            if (Guard.IsNull(entity))
            {
                return;
            }

            //ShowViewModel();
        }

        #endregion

        #region public

        public async override void Start()
        {
            GetContacts();

            base.Start();
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}