using System;
using System.Collections;
using System.Collections.Generic;
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

        private ICollection<Contact> _contacts;

        #endregion

        #region methods

        #region private

        private async void GetContacts()
        {
            _contactService.ContactsChanged += OnContactsChanged;

            try
            {
                _contactService.GetContacts();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void OnContactsChanged(object sender, ContactsChangedEventArgs e)
        {
            _contactService.ContactsChanged -= OnContactsChanged;
            
            Contacts = e.Contacts;
        }

        #endregion

        #region protected

        protected async override void SelectionChanged(Contact entity)
        {
            throw new NotImplementedException();
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

        public ICollection<Contact> Contacts
        {
            get { return _contacts; }
            private set
            {
                _contacts = value;
                RaisePropertyChanged(() => Contacts);
            }
        }

        #endregion
    }
}