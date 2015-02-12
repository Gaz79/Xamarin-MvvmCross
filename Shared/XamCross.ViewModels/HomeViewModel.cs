using System;
using System.Collections.ObjectModel;

using XamCross.Models;

namespace XamCross.ViewModels
{
    public class HomeViewModel : AbstractListViewModel<Menu>
    {
        #region constructors

        public HomeViewModel()
            : base()
        {
            Items = new Collection<Menu>
            {
                new Menu { Title = "Contacts Demo", Description = "", Icon = "", ViewModelType = typeof (ContactListViewModel) },
                new Menu { Title = "Demo", Description = "", Icon = "", ViewModelType = typeof (HomeViewModel) },
                new Menu { Title = "Demo", Description = "", Icon = "", ViewModelType = typeof (HomeViewModel) },
                new Menu { Title = "Demo", Description = "", Icon = "", ViewModelType = typeof (HomeViewModel) },
                new Menu { Title = "Demo", Description = "", Icon = "", ViewModelType = typeof (HomeViewModel) },
            };
        }

        #endregion

        #region fields

        #endregion

        #region methods

        #region protected

        protected async override void SelectionChanged(Menu entity)
        {
            if (Guard.IsNull(entity))
            {
                return;
            }

            ShowViewModel(entity.ViewModelType);
        }

        #endregion

        #endregion

        #region properties

        #endregion
    }
}