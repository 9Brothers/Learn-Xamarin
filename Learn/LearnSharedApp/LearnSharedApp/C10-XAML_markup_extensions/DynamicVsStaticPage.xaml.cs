using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LearnSharedApp.C10_XAML_markup_extensions
{
	public partial class DynamicVsStaticPage : ContentPage
	{
		public DynamicVsStaticPage ()
		{
			InitializeComponent ();

      Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
          Resources["currentDateTime"] = DateTime.Now.ToString();

          return true;
        });
		}
	}
}
