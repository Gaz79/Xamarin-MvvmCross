﻿using System;
using System.Collections.Generic;

using Cirrious.CrossCore;

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
            _contactService.ContactsChanged += OnContactsChanged;

            try
            {
                await _contactService.GetContactsAsync();
            }
            catch (Exception ex)
            {
                Mvx.Trace(string.Format("ContactListViewModel::GetContacts --> {0}", ex.Message));
                throw;
            }
            finally
            {
                _contactService.ContactsChanged -= OnContactsChanged;
            }
        }

        private async void OnContactsChanged(object sender, ContactsChangedEventArgs e)
        {
            Items = e.Contacts as ICollection<Contact>;
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