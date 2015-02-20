using System;
using System.Collections.Generic;

namespace XamCross.Plugins.Contacts
{
    public class ContactsChangedEventArgs : EventArgs
    {
        public ContactsChangedEventArgs(IEnumerable<Contact> contacts)
        {
            Contacts = contacts;
        }

        public IEnumerable<Contact> Contacts { get; private set; }
    }
}