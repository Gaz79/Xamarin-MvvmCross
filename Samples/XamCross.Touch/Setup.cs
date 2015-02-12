using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.ViewModels;

using UIKit;

using XamCross.ViewModels;

namespace XamCross.Touch
{
    public class Setup : MvxTouchSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}