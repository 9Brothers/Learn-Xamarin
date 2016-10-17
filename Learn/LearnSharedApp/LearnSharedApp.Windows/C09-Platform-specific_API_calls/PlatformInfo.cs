using LearnSharedApp.C09_Platform_specific_API_calls;
using System;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Xamarin.Forms;

[assembly: Dependency(typeof(LearnSharedApp.Windows.C09_Platform_specific_API_calls.PlatformInfo))]

namespace LearnSharedApp.Windows.C09_Platform_specific_API_calls
{
  public class PlatformInfo
  {
    EasClientDeviceInformation devInfo = new EasClientDeviceInformation();

    public String Model
    {
      get { return String.Format($"{devInfo.SystemManufacturer} {devInfo.SystemProductName}"); }
    }

    public String Version
    {
      get { return devInfo.OperatingSystem; }
    }
  }
}
