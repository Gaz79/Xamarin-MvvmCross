using System;
using System.Linq;

namespace XamCross.Plugins.Contacts.WindowsPhoneStore
{
    public static class ContactExtensions
    {
        public static Contact Transform(this Windows.ApplicationModel.Contacts.Contact contact)
        {
            try
            {
                return new Contact
                {
                    DisplayName = string.Format("{0} {1}", contact.FirstName, contact.LastName),
                    //LastName = contact.LastName,
                    //HomeEmail = contact.Emails.Count > 0 ? contact.Emails.FirstOrDefault(c => c.Kind.Equals(Windows.ApplicationModel.Contacts.ContactEmailKind.Personal)).Address : "",
                    //HomePhone = contact.Phones.Count > 0 ? contact.Phones.FirstOrDefault(c => c.Kind.Equals(Windows.ApplicationModel.Contacts.ContactPhoneKind.Home)).Number : "",
                    //MobilePhone = contact.Phones.Count > 0 ? contact.Phones.FirstOrDefault(c => c.Kind.Equals(Windows.ApplicationModel.Contacts.ContactPhoneKind.Mobile)).Number : "",
                    //WorkEmail = contact.Emails.Count > 0 ? contact.Emails.FirstOrDefault(c => c.Kind.Equals(Windows.ApplicationModel.Contacts.ContactEmailKind.Work)).Address : "",
                    //WorkPhone = contact.Phones.Count > 0 ? contact.Phones.FirstOrDefault(c => c.Kind.Equals(Windows.ApplicationModel.Contacts.ContactPhoneKind.Work)).Number : "",
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}