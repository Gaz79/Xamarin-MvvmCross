# Xamarin-MvvmCross


## Disclaimer

> - **The views, patterns and practices in these samples are my personal views and opinions and is for the sole purpose of documenting my journey through learning and developing in Xamarin and MvvmCross.**
- **If this can be helpfull to someone else then this project will be a success.**
- **I also urge anyone looking at this project to challenge me at any point regarding the technical or coding decisions I may have made during the development of this application.**

## The Project

- **I will try to minimise any dependencies on 3rd party libraries as much as possible, sticking to the latest stable release of Xamarin for Visual Studio and MvvmCross as of 12 Feb 2015.**
- **Xamarin 3.9.236.0**
- **Xamarin.Android 4.20.0.34**
- **Xamarin.iOS 8.6.0.0**
- **Xamarin.iOS.Unified Migration 1.0**
- **MvvmCross.* 3.5.0**

## The Funnies

- **There is currently a known bug with the Xamarin for Android integration into Visual Studio.**
- **Please make sure that you always explicitly set "Compile using Android version:" under the Application Section of the Project Properties.**
- **If you set it to "Use Latest Platform..." it doesn't stamp the .csproj file and nuget will install packages for the default MonoAndroid22 instead of your preferred api.**