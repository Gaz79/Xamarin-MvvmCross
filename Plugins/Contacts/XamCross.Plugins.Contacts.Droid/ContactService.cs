using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Android.Content;
using Android.Database;
using Android.Provider;

namespace XamCross.Plugins.Contacts.Droid
{
    public class ContactService : AbstractContactService
    {
        #region constructors

        public ContactService()
        {
            _uri = ContactsContract.Contacts.ContentUri;
        }

        #endregion

        #region fields

        private readonly Android.Net.Uri _uri;

        #endregion

        #region methods

        #region public

        public static IContactService Create()
        {
            return new ContactService();
        }

        public override ICollection<Contact> GetContacts()
        {
            var contacts = new Collection<Contact>();

            try
            {
                var activity = Utilities.GetActivityContext();

                string[] projection = { 
                                          ContactsContract.Contacts.InterfaceConsts.Id, 
                                          ContactsContract.Contacts.InterfaceConsts.DisplayName,
                                          ContactsContract.Contacts.InterfaceConsts.HasPhoneNumber,
                                      };

                var loader = new CursorLoader(activity, _uri, projection, null, null, null);
                var cursor = (ICursor)loader.LoadInBackground();

                if (cursor.MoveToFirst())
                {
                    do
                    {
                        contacts.Add(cursor.Transform(activity, projection));
                    }
                    while (cursor.MoveToNext());
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return contacts;
        }

        public override async Task<ICollection<Contact>> GetContactsAsync()
        {
            return await Task.Run(() => GetContacts());
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}