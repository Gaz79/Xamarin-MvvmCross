using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts
{
    public abstract class AbstractContactService : IContactService
    {
        public event ContactsChangedEventHandler ContactsChanged;

        protected virtual void OnContactsChanged(IEnumerable<Contact> contacts)
        {
            var handler = ContactsChanged;

            if (Guard.IsNotNull(handler))
            {
                handler(this, new ContactsChangedEventArgs(contacts));
            }
        }

        public abstract void GetContacts();

        public abstract Task GetContactsAsync();
    }
}