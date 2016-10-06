using System;
using Xamarin.Forms;

namespace Learn.Chapters.C02
{
  public class GreetingsPage : ContentPage
  {
    public GreetingsPage()
    {
      Content = new Label
      {
        Text = "Greetings, Xamarin.Forms!",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        FontAttributes = FontAttributes.Bold | FontAttributes.Italic
      };

      Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
    }
  }
}
