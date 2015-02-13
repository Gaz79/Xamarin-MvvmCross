using System;
using System.Threading.Tasks;

namespace XamCross.Plugins.Contacts
{
    public delegate void ContactsChangedEventHandler(object sender, ContactsChangedEventArgs e);

    public interface IContactService
    {
        event ContactsChangedEventHandler ContactsChanged;

        void GetContacts();

        Task GetContactsAsync();
    }
}