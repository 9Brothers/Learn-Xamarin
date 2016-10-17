using LearnSharedApp.C09_Platform_specific_API_calls;
using System;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(LearnSharedApp.iOS.C09_Platform_specific_API_calls.PlatformInfo))]

namespace LearnSharedApp.iOS.C09_Platform_specific_API_calls
{
  class PlatformInfo : IPlatformInfo
  {
    UIDevice device = new UIDevice();

    public String Model
    {
      get { return device.Model.ToString(); }
    }

    public String Version
    {
      get { return String.Format($"{device.SystemName} {device.SystemVersion}"); }
    }
  }
}
