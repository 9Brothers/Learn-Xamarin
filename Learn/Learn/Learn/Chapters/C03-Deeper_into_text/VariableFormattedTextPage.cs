using System;
using Xamarin.Forms;

namespace Learn.Chapters.C03
{
  public class VariableFormattedTextPage : ContentPage
  {
    public VariableFormattedTextPage()
    {
      var formattedString = new FormattedString();

      formattedString.Spans.Add(new Span { Text = "I " });
      formattedString.Spans.Add(new Span {
        Text = "love",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        FontAttributes = FontAttributes.Bold
      });
      formattedString.Spans.Add(new Span { Text = " Xamarin.Forms!" });

      Content = new Label
      {
        FormattedText = formattedString,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
      };
    }
  }
}
