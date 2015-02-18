# Xamarin Android
>
- There is currently a known bug with the Xamarin for Android integration into Visual Studio.
- Please make sure that you always explicitly set "Compile using Android version:" under the Application Section of the Project Properties.
- If you set it to "Use Latest Platform..." it doesn't stamp the .csproj file and nuget will install packages for the default MonoAndroid22 instead of your preferred api.
- The initial views in the Xamaron Android app will be based activities, but that will soon change to fragments as that is my personal preference and does make it much easier to target different sized devices without much code duplication.
