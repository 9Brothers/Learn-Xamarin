using System;
using Android.OS;
using Xamarin.Forms;
using LearnSharedApp.C09_Platform_specific_API_calls;

[assembly: Dependency(typeof(LearnSharedApp.Droid.C09_Platform_specific_API_calls.PlatformInfo))]

namespace LearnSharedApp.Droid.C09_Platform_specific_API_calls
{
  class PlatformInfo : IPlatformInfo
  {
    public String Model
    {
      get { return String.Format($"{Build.Manufacturer} {Build.Model}"); }
    }

    public String Version
    {
      get { return Build.VERSION.Release.ToString(); }
    }
  }
}