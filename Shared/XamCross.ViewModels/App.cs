using System;

using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;

namespace XamCross.ViewModels
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}