using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts
{
    public abstract class AbstractContactService : IContactService
    {
        public virtual ICollection<Contact> GetContacts()
        {
            return Task.Run(async () => await GetContactsAsync()).Result;
        }

        public virtual Task<ICollection<Contact>> GetContactsAsync()
        {
            throw new NotImplementedException();
        }
    }
}