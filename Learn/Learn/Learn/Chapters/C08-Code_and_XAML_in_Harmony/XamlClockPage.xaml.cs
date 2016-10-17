using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Learn.Chapters.C08_Code_and_XAML_in_Harmony
{
  public partial class XamlClockPage : ContentPage
  {
    public XamlClockPage()
    {
      InitializeComponent();

      Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
    }

    private bool OnTimerTick()
    {
      var dt = DateTime.Now;

      timeLabel.Text = dt.ToString("T");
      dateLabel.Text = dt.ToString("D");

      return true;
    }
  }
}
