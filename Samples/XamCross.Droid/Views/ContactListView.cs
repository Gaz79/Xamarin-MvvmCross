using System;

using Android.App;
using Android.OS;

using Cirrious.MvvmCross.Droid.Views;

using XamCross.ViewModels;

namespace XamCross.Droid.Views
{
    [Activity(Label = "Contacts")]
    public class ContactListView : MvxActivity
    {
        #region constructors

        #endregion

        #region fields

        #endregion

        #region methods

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ContactListView_Activity);
        }

        #endregion

        #region properties

        public new ContactListViewModel ViewModel
        {
            get { return (base.ViewModel as ContactListViewModel); }
            set { base.ViewModel = value; }
        }

        #endregion
    }
}