using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C04_Scrolling_the_stack
{
  class BlackCatPage : ContentPage
  {
    public BlackCatPage()
    {
      var mainStack = new StackLayout();
      var textStack = new StackLayout
      {
        Padding = new Thickness(5),
        Spacing = 10
      };

      var assenbly = GetType().GetTypeInfo().Assembly;

      var resource = "Learn.Assets.Texts.TheBlackCat.txt";

      using (var stream = assenbly.GetManifestResourceStream(resource))
      {
        using (var reader = new StreamReader(stream))
        {
          var gotTitle = false;
          var line = String.Empty;

          while (null != (line = reader.ReadLine()))
          {
            var label = new Label
            {
              Text = line,
              TextColor = Color.Black
            };

            if (!gotTitle)
            {
              label.HorizontalOptions = LayoutOptions.Center;
              label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
              label.FontAttributes = FontAttributes.Bold;
              mainStack.Children.Add(label);
              gotTitle = true;
            }
            else
            {
              textStack.Children.Add(label);
            }
          }
        }
      }

      var scrollView = new ScrollView
      {
        Content = textStack,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Padding = new Thickness(5, 0)
      };

      mainStack.Children.Add(scrollView);

      Content = mainStack;

      BackgroundColor = Color.White;

      Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
    }
  }
}
