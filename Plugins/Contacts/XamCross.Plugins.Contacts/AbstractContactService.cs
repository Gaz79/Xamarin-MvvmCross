using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts
{
    public abstract class AbstractContactService : IContactService
    {
        public abstract ICollection<Contact> GetContacts();

        public abstract Task<ICollection<Contact>> GetContactsAsync();
    }
}