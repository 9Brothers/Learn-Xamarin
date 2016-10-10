using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C04_Scrolling_the_stack
{
  public class FramedTextPage : ContentPage
  {
    public FramedTextPage()
    {
      Padding = new Thickness(20);

      BackgroundColor = Color.Aqua;

      Content = new Frame
      {
        OutlineColor = Color.Black,
        BackgroundColor = Color.Yellow,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,

        Content = new Label
        {
          Text = "I've been framed!",
          FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
          FontAttributes = FontAttributes.Italic,
          TextColor = Color.Blue
        }
      };
    }
  }
}
