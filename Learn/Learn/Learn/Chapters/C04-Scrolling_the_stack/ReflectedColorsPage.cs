using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C04_Scrolling_the_stack
{
  public class ReflectedColorsPage : ContentPage
  {
    public ReflectedColorsPage()
    {
      var stackLayout = new StackLayout();

      foreach (var info in typeof(Color).GetRuntimeFields())
      {
        if (info.GetCustomAttribute<ObsoleteAttribute>() != null) continue;

        if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color))
        {
          stackLayout.Children.Add(
            CreateColorLabel((Color)info.GetValue(null), info.Name));
        }
      }

      foreach (var info in typeof(Color).GetRuntimeProperties())
      {
        var methodInfo = info.GetMethod;

        if (methodInfo.IsPrivate && methodInfo.IsStatic && methodInfo.ReturnType == typeof(Color))
        {
          stackLayout.Children.Add(
            CreateColorLabel((Color)info.GetValue(null), info.Name));
        }
      }

      Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);

      Content = new ScrollView
      {
        Content = stackLayout
      }; 
    }

    Label CreateColorLabel(Color color, String name)
    {
      var backgroundColor = Color.Default;

      if (color != Color.Default)
      {
        var luminance =
          0.3 * color.R +
          0.59 * color.G +
          0.11 * color.B;

        backgroundColor = luminance > 0.5 ? Color.Black : Color.White;
      }

      return new Label
      {
        Text = name,
        TextColor = color,
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        BackgroundColor = backgroundColor
      };
    }
  }
}
