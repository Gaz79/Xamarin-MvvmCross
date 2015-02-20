using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AddressBook;

using Foundation;

namespace XamCross.Plugins.Contacts.Touch
{
    public class ContactService : AbstractContactService
    {
        #region constructors

        public ContactService()
        {
        }

        #endregion

        #region fields

        #endregion

        #region methods

        #region private

        #endregion

        #region public

        public static IContactService Create()
        {
            return new ContactService();
        }

        public override ICollection<Contact> GetContacts()
        {
            try
            {
                NSError error;

                using (var addressBook = ABAddressBook.Create(out error))
                {
                    if (Guard.IsNotNull(error) || Guard.IsNull(addressBook))
                    {
                        // instructions
                    }
                    else if (ABAddressBook.GetAuthorizationStatus() != ABAuthorizationStatus.Authorized)
                    {
                        addressBook.RequestAccess((granted, err) =>
                        {
                            if (Guard.IsNotNull(err))
                            {
                                // instructions
                            }
                            else if (granted)
                            {
                                // get people
                            }
                        });
                    }
                    else
                    {
                        // get people
                    }

                    var contacts = addressBook.GetPeople();

                    return contacts.Select(p => p.Transform()).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
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