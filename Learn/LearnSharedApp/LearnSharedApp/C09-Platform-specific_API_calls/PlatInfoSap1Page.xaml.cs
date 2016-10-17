using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#if __IOS__
//using LearnSharedApp.iOS.C09_Platform_specific_API_calls;

//#elif __ANDROID__
//using LearnSharedApp.Droid.C09_Platform_specific_API_calls;

//#elif WINDOWS_APP || WINDOWS_PHONE_APP || WINDOWS_UWP
//using LearnSharedApp.Windows.C09_Platform_specific_API_calls;

//#endif

using Xamarin.Forms;

namespace LearnSharedApp.C09_Platform_specific_API_calls
{
	public partial class PlatInfoSap1Page : ContentPage
	{
		public PlatInfoSap1Page ()
		{
			InitializeComponent ();

//#if __IOS__
//      var device = new UIDevice();
//      modelLabel.Text = device.Model.ToString();
//      versionLabel.Text  = String.Format($"{device.SystemName} {device.SystemVersion}");
            
//#elif __ANDROID__
//      modelLabel.Text = String.Format($"{Build.Manufacturer} {Build.Model}");
//      versionLabel.Text = Build.VERSION.Release.ToString();

//#elif WINDOWS_APP || WINDOWS_PHONE_APP || WINDOWS_UWP
//      var devInfo = new EasClientDeviceInformation();
//      modelLabel.Text = String.Format($"{devInfo.SystemManufacturer} {devInfo.SystemProductName}");
//      versionLabel.Text = devInfo.OperatingSystem;
//#endif


      //var platformInfo = new PlatformInfo();
      //modelLabel.Text = platformInfo.Model;
      //versionLabel.Text = platformInfo.Version;
    }
	}
}
