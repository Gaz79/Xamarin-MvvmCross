using System;

using Cirrious.MvvmCross.WindowsCommon.Views;

using XamCross.ViewModels;

namespace XamCross.Phone.Views
{
    public sealed partial class HomeView : MvxWindowsPage
    {
        public HomeView()
        {
            this.InitializeComponent();
        }

        public new HomeViewModel ViewModel
        {
            get { return base.ViewModel as HomeViewModel; }
        }
    }
}