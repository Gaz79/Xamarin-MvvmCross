using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts
{
    public abstract class AbstractContactService : IContactService
    {
        public event ContactsChangedEventHandler ContactsChanged;

        protected void OnContactsChanged(ICollection<Contact> contacts)
        {
            var handler = ContactsChanged;

            if (Guard.IsNotNull(handler))
            {
                handler(this, new ContactsChangedEventArgs(contacts));
            }
        }

        public virtual void GetContacts()
        {
            throw new NotImplementedException();
        }

        public virtual Task GetContactsAsync()
        {
            throw new NotImplementedException();
        }
    }
}