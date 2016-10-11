using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C05_Dealing_with_sizes
{
  class MetricalBoxViewPage : ContentPage
  {
    public MetricalBoxViewPage()
    {
      Content = new BoxView
      {
        Color = Color.Accent,
        WidthRequest = 64,
        HeightRequest = 160,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };
    }
  }
}
