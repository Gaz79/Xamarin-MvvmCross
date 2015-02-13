using System;

namespace XamCross.Plugins.Contacts
{
    public class Contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomeEmail { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string WorkEmail { get; set; }

        public string WorkPhone { get; set; }

        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}