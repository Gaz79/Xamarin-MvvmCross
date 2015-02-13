using System;
using System.Collections.Generic;

namespace XamCross.Plugins.Contacts
{
    public class ContactsChangedEventArgs : EventArgs
    {
        public ContactsChangedEventArgs(ICollection<Contact> contacts)
        {
            Contacts = contacts;
        }

        public ICollection<Contact> Contacts { get; private set; }
    }
}