using System;
using System.Linq;
using System.Threading.Tasks;

using Cirrious.CrossCore;

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

        public override void GetContacts()
        {
            GetContactsAsync().Wait();
        }

        public override async Task GetContactsAsync()
        {
            try
            {
                var contacts = await _contactStore.FindContactsAsync();

                OnContactsChanged(contacts.Select(c => c.Transform()));
            }
            catch (Exception ex)
            {
                Mvx.Trace(string.Format("ContactService::GetContactsAsync --> {0}", ex.Message));
                throw;
            }
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}