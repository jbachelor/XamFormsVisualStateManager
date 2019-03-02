# Xamarin.Forms Visual State Manager
This is a small demo app to show how to use the [VisualStateManager](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual-state-manager) in Xamarin.Forms to control the look of controls depending on the value of their [IsEnabled](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.isenabled?view=xamarin-forms) property. This is just the tip of the VisualStateManager iceberg, but it's a great place to start.

## Why is this sample here?
It was not too long ago when I thought I had almost no control at all over how various view elements would look in Xamarin.Forms when their IsEnabled property would get set to false. The stages of discovery went a little something like this:
1. Holy guacamole... I have no control whatsoever over how a button looks when it is disabled!
2. I'm so, so, so, sad... In order to control the look when disabled, I'm going to have to write a [custom renderer](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/custom-renderer/introduction).
3. Well, at least I have some limited control over the disabled look using [styles](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/styles/xaml/index) and a [data trigger](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/triggers) based on the value of IsEnabled. Still a pretty icky UI.
4. Rejoice!! The VisualStateManager gives me complete control over the look when disabled without delving into the bowels of each platform using a custom renderer!

Furthermore, I am a huge fan of the the [Prism MVVM framework](https://prismlibrary.github.io/) in conjunction with Xamarin.Forms, and I believe the more sample code available the better! This demo app will show you how to customize the look of a styled button when it is disabled, in a very simple Xamarin.Forms app using the Prism MVVM framework.

**Quick Note**:  You might notice the switch control is slightly customized, since I strongly dislike the default pink color used on the Android switch by default:
* There is an implicit style set for the switch OnColor in App.xaml.cs (in the cross-platform project). 
* The value for "colorAccent" in the Android project's styles.xml file has been changed to be not pink.
* You can view the actual code changes in [this commit](https://github.com/jbachelor/XamFormsVisualStateManager/commit/2fed5c837e5ce4b34547f28c84f9b856554b5adf).

***
## Keep an eye on your ApplicationOutput pad/tab
There are Debug.WriteLine calls throughout the sample code to illustrate app flow, show you when the buttons are responding to taps, etc.
![App running with output tab in the background](AppOutput.png "App running with output tab in the background")

***
## Enabled Look
![App with buttons enabled](Enabled.png "App with buttons enabled")

***
## Disabled Look
![App with buttons disabled](Disabled.png "App with buttons disabled")
