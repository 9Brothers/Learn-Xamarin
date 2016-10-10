using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C04_Scrolling_the_stack
{
  public class ColorListPage : ContentPage
  {
    public ColorListPage()
    {
      Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);

      var fontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

      Content = new StackLayout
      {
        Children =
        {
          new Label
          {
            Text = "White",
            TextColor = Color.White,
            FontSize = fontSize
          },
          new Label
          {
            Text = "Silver",
            TextColor = Color.Silver,
            FontSize = fontSize
          },
          new Label
          {
            Text = "Fuchsia",
            TextColor = Color.Fuchsia,
            FontSize = fontSize
          },
          new Label
          {
            Text = "Purple",
            TextColor = Color.Purple,
            FontSize = fontSize
          }
        }
      };
    }
  }
}
