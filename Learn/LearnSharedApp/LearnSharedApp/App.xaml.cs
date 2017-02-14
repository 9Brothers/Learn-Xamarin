using LearnSharedApp.C09_Platform_specific_API_calls;
using LearnSharedApp.C10_XAML_markup_extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnSharedApp.Toolkit;

using Xamarin.Forms;

namespace LearnSharedApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

      #region Chapter 9 - Platform specific API calls
      //MainPage = new LearnSharedApp.MainPage();
      //MainPage = new PlatInfoSap1Page();
      #endregion

      #region Chapter 10 - XAML markup extensions
      //MainPage = new SharedStaticsPage();
      //MainPage = new SystemStaticsPage();
      //MainPage = new DynamicVsStaticPage();      
      //Toolkit.Toolkit.Init();
      //MainPage = new CustomExtensionDemoPage();
      #endregion

      #region Chapter 11 - The bindable infrastructure
      
      #endregion
    }

    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
