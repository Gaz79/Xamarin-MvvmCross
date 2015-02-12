using System;

using Cirrious.MvvmCross.WindowsCommon.Views;

using Windows.UI.Xaml.Controls;

using XamCross.ViewModels;

namespace XamCross.Phone.Views
{
    public sealed partial class HomeView : MvxWindowsPage
    {
        #region constructors

        public HomeView()
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

        public new HomeViewModel ViewModel
        {
            get { return (base.ViewModel as HomeViewModel); }
        }

        #endregion
    }
}