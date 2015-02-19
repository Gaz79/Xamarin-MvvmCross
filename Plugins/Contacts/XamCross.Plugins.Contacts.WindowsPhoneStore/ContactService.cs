using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Windows.ApplicationModel.Contacts;

namespace XamCross.Plugins.Contacts.WindowsPhoneStore
{
    public class ContactService : AbstractContactService
    {
        #region constructors

        public ContactService()
        {
            _contactStore = Task.Run(async () => await ContactManager.RequestStoreAsync()).Result;
        }

        #endregion

        #region fields

        private readonly ContactStore _contactStore;

        #endregion

        #region methods

        #region public

        public static IContactService Create()
        {
            return new ContactService();
        }

        public override ICollection<Contact> GetContacts()
        {
            return Task.Run(async () => await GetContactsAsync()).Result;
        }

        public override async Task<ICollection<Contact>> GetContactsAsync()
        {
            try
            {
                var contacts = await _contactStore.FindContactsAsync();

                return contacts.Select(c => c.Transform()).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}