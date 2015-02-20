using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AddressBook;

namespace XamCross.Plugins.Contacts.Touch
{
    public class ContactService : AbstractContactService
    {
        #region constructors

        #endregion

        #region fields

        private ABAddressBook _addressBook;

        #endregion

        #region methods

        #region public

        public static IContactService Create()
        {
            return new ContactService();
        }

        public override ICollection<Contact> GetContacts()
        {
            try
            {
                var contacts = _addressBook.GetPeople();

                return contacts.Select(p => p.Transform()).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public override async Task<ICollection<Contact>> GetContactsAsync()
        {
            return await Task.Run(() => GetContacts());
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}