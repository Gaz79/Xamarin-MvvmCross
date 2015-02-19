using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts.Touch
{
    public class ContactService : AbstractContactService
    {
        #region constructors

        #endregion

        #region fields

        #endregion

        #region methods

        #region public

        public static IContactService Create()
        {
            return new ContactService();
        }

        public override ICollection<Contact> GetContacts()
        {
            throw new NotImplementedException();
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