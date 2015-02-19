using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts
{
    public interface IContactService
    {
        ICollection<Contact> GetContacts();

        Task<ICollection<Contact>> GetContactsAsync();
    }
}