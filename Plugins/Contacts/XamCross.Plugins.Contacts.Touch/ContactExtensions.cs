using System;

using AddressBook;

namespace XamCross.Plugins.Contacts.Touch
{
    public static class ContactExtensions
    {
        public static Contact Transform(this ABPerson person)
        {
            return new Contact
            {
                //Id = person.Id.ToString(),
                FirstName = person.FirstName,
                LastName = person.LastName,
                DisplayName = string.Format("{0} {1}", person.FirstName, person.LastName),
            };
        }
    }
}