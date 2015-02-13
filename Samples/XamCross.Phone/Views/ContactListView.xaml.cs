using System;

using Cirrious.MvvmCross.WindowsCommon.Views;

using Windows.UI.Xaml.Controls;

using XamCross.ViewModels;

namespace XamCross.Phone.Views
{
    public sealed partial class ContactListView : MvxWindowsPage
    {
        #region constructors

        public ContactListView()
        {
            this.InitializeComponent();
        }

        #endregion

        #region fields

        #endregion

        #region methods

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.AddedItems[0];

            if (item == null)
            {
                return;
            }

            ViewModel.SelectionChangedCommand.Execute(item);
        }

        #endregion

        #region properties

        public new ContactListViewModel ViewModel
        {
            get { return (base.ViewModel as ContactListViewModel); }
        }

        #endregion
    }
}