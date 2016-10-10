using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C03
{
  public class NamedFontSizesPage : ContentPage
  {
    public NamedFontSizesPage()
    {
      var formattedString = new FormattedString();
      NamedSize[] namedSizes =
      {
        NamedSize.Default, NamedSize.Micro, NamedSize.Small,
        NamedSize.Medium, NamedSize.Large
      };

      foreach (var namedSize in namedSizes)
      {
        var fontSize = Device.GetNamedSize(namedSize, typeof(Label));

        formattedString.Spans.Add(new Span
        {
          Text = String.Format("Named Size = {0} ({1:F2})", namedSize, fontSize),
          FontSize = fontSize
        });

        if (namedSize != namedSizes.Last())
        {
          formattedString.Spans.Add(new Span {
              Text = Environment.NewLine + Environment.NewLine
          });
        }
      }

      Content = new Label
      {
        FormattedText = formattedString,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };
    }
  }
}
