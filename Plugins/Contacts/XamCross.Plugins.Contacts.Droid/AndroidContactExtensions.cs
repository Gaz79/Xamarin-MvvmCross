using System;

using Android.Content;
using Android.Database;
using Android.Provider;

namespace XamCross.Plugins.Contacts.Droid
{
    public static class AndroidContactExtensions
    {
        public static Contact Transform(this ICursor cursor, Context activity, string[] projection)
        {
            try
            {
                //  get contact detail
                var hasPhoneNo = (int.Parse(cursor.GetString(cursor.GetColumnIndex(projection[2]))) == 1);

                //  only add contacts with a phone no
                if (hasPhoneNo)
                {
                    var p = new[] { ContactsContract.CommonDataKinds.Phone.Number };

                    var l = new CursorLoader(activity, ContactsContract.CommonDataKinds.Phone.ContentUri, p, null, null, null);
                    var c = (ICursor)l.LoadInBackground();

                    //Get the first phone number
                    if (c.MoveToFirst())
                    {
                        //contact.DefaultContact = c.GetString(c.GetColumnIndex(p[0]));
                    }
                }

                return new Contact
                {
                    DisplayName = cursor.GetString(cursor.GetColumnIndex(projection[1])),
                    //LastName = cursor.GetString(cursor.GetColumnIndex(projection[1])),
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