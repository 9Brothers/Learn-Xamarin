using System;
using Xamarin.Forms;

namespace Learn.Chapters.C04_Scrolling_the_stack
{
  class SizedBoxViewPage : ContentPage
  {
    public SizedBoxViewPage()
    {
      BackgroundColor = Color.Pink;

      Content = new BoxView
      {
        Color = Color.Navy,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        WidthRequest = 200,
        HeightRequest = 100        
      };
    }
  }
}
