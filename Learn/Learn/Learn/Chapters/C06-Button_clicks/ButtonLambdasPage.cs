using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C06_Button_clicks
{
  class ButtonLambdasPage : ContentPage
  {
    public ButtonLambdasPage()
    {
      var number = 1.0;

      var label = new Label
      {
        Text = number.ToString(),
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.CenterAndExpand
      };

      var timesButton = new Button
      {
        Text = "Double",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
        HorizontalOptions = LayoutOptions.CenterAndExpand
      };

      timesButton.Clicked += (sender, e) =>
      {
        number *= 2;
        label.Text = number.ToString();
      };

      var divideButton = new Button
      {
        Text = "Half",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
        HorizontalOptions = LayoutOptions.CenterAndExpand
      };

      divideButton.Clicked += (sender, e) =>
      {
        number /= 2;
        label.Text = number.ToString();
      };

      Content = new StackLayout
      {
        Children =
        {
          label,
          new StackLayout
          {
            Orientation = StackOrientation.Horizontal,
            VerticalOptions = LayoutOptions.CenterAndExpand,
            Children =
            {
              timesButton,
              divideButton
            }
          }
        }
      };
    }
  }
}
