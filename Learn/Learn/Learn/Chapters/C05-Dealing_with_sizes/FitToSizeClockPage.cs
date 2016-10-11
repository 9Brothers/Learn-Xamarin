using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C05_Dealing_with_sizes
{
  class FitToSizeClockPage : ContentPage
  {
    public FitToSizeClockPage()
    {
      var clockLabel = new Label
      {
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };

      Content = clockLabel;

      SizeChanged += (object sender, EventArgs e) =>
      {
        if (this.Width > 0) clockLabel.FontSize = this.Width / 6;
      };

      Device.StartTimer(TimeSpan.FromSeconds(1), () =>
      {
        clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");

        return true;
      });
    }
  }
}
