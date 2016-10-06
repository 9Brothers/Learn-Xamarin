using System;
using Xamarin.Forms;

namespace Learn.Chapters.C02
{
  public class Hello : ContentPage
  {
    public Hello()
    {
      Content = new StackLayout
      {
        VerticalOptions = LayoutOptions.Center,
        Children =
          {
            new Label
            {
              HorizontalTextAlignment = TextAlignment.Center,
              Text = "Welcome to Xamarin Forms!"
            }
          }
      };
    }
  }
}
