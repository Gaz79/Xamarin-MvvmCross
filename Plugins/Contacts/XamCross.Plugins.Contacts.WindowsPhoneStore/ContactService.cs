using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts.WindowsPhoneStore
{
    public class ContactService : AbstractContactService
    {
        #region constructors

        public ContactService()
        {
        }

        #endregion

        #region fields

        #endregion

        #region methods

        #region private

        private static async Task<IList<Windows.ApplicationModel.Contacts.Contact>> GetPhoneContactsAsync()
        {
            var picker = new Windows.ApplicationModel.Contacts.ContactPicker();

            picker.DesiredFieldsWithContactFieldType.Add(Windows.ApplicationModel.Contacts.ContactFieldType.PhoneNumber);

            return await picker.PickContactsAsync();
        }

        #endregion

        #region public

        public static IContactService Create()
        {
            return new ContactService();
        }

        public override void GetContacts()
        {
            var contacts = new Collection<Contact>();

            try
            {
                GetPhoneContactsAsync().ContinueWith(task =>
                {
                    foreach (var contact in task.Result)
                    {
                        contacts.Add(contact.Transform());
                    }

                    OnContactsChanged(contacts);
                });
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