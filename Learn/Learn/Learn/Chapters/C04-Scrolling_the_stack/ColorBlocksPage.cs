using System;
using Xamarin.Forms;

namespace Learn.Chapters.C04_Scrolling_the_stack
{
  class ColorBlocksPage : ContentPage
  {
    public ColorBlocksPage()
    {
      var colors = new[] {
        //new { value = Color.White, name = "Ed" },
        new { value = Color.Silver, name = "Edneide" },
        new { value = Color.Gray, name = "Farias" },
        new { value = Color.Black, name = "de" },
        new { value = Color.Red, name = "Sousa" },
        new { value = Color.Maroon, name = "Você" },
        new { value = Color.Yellow, name = "é" },
        new { value = Color.Olive, name = "a" },
        new { value = Color.Lime, name = "mulher" },
        new { value = Color.Green, name = "mais" },
        new { value = Color.Aqua, name = "linda" },
        new { value = Color.Teal, name = "do" },
        new { value = Color.Blue, name = "universo" },
        new { value = Color.Navy, name = "Navy" },
        new { value = Color.Pink, name = "Pink" },
        new { value = Color.Fuchsia, name = "Fuchsia" },
        new { value = Color.Purple, name = "Purple" }
      };

      var stackLayout = new StackLayout();

      foreach (var color in colors)
      {
        stackLayout.Children.Add(CreateColorView(color.value, color.name));
      }

      Content = new ScrollView
      {
        Content = stackLayout,
        Padding = new Thickness(20, Device.OnPlatform(40, 20, 20), 20, 20)
      };      
    }

    View CreateColorView(Color color, String name)
    {
      return new Frame
      {
        OutlineColor = Color.Accent,
        Padding = new Thickness(5),
        Content = new StackLayout
        {
          Orientation = StackOrientation.Horizontal,
          Spacing = 15,
          Children =
          {
            new BoxView
            {
              Color = color
            },
            new Label
            {
              Text = name,
              FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
              FontAttributes = FontAttributes.Bold,
              VerticalOptions = LayoutOptions.Center,
              HorizontalOptions = LayoutOptions.StartAndExpand
            },
            new StackLayout
            {
              Children =
              {
                new Label
                {
                  Text = String.Format("{0:X2}-{1:X2}-{2:X2}",
                    (int)(255 * color.R),
                    (int)(255 * color.G),
                    (int)(255 * color.B)),
                  VerticalOptions = LayoutOptions.CenterAndExpand,
                  IsVisible = color != Color.Default
                },
                new Label
                {
                  Text = String.Format("{0:F2}, {1:F2}, {2:F2}",
                    color.Hue,
                    color.Saturation,
                    color.Luminosity),
                  VerticalOptions = LayoutOptions.CenterAndExpand,
                  IsVisible = color != Color.Default
                }
              },
              HorizontalOptions = LayoutOptions.End
            }
          }
        }
      };
    }
  }
}
