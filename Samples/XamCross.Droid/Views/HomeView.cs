using Android.App;
using Android.OS;

using Cirrious.MvvmCross.Droid.Views;

using XamCross.ViewModels;

namespace XamCross.Droid.Views
{
    [Activity(Label = "Home")]
    public class HomeView : MvxActivity
    {
        #region constructors

        #endregion

        #region fields

        #endregion

        #region methods

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.HomeView);
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