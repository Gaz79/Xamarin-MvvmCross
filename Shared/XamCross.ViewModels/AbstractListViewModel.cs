using System;
using System.Collections.Generic;
using System.Windows.Input;

using Cirrious.MvvmCross.ViewModels;

namespace XamCross.ViewModels
{
    public abstract class AbstractListViewModel<TEntity> : AbstractViewModel where TEntity : class
    {
        #region constructors

        protected AbstractListViewModel()
        {
            SelectionChangedCommand = new MvxCommand<TEntity>(SelectionChanged);
        }

        #endregion

        #region fields

        private ICollection<TEntity> _items;

        #endregion

        #region methods

        protected abstract void SelectionChanged(TEntity entity);

        #endregion

        #region properties

        public virtual ICollection<TEntity> Items
        {
            get { return _items; }
            protected set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        public virtual ICommand SelectionChangedCommand
        {
            get;
            private set;
        }

        #endregion
    }
}