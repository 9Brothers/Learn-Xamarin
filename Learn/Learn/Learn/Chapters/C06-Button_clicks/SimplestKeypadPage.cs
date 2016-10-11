using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C06_Button_clicks
{
  class SimplestKeypadPage : ContentPage
  {
    Label displayLabel;
    Button backspaceButton;

    public SimplestKeypadPage()
    {
      var mainStack = new StackLayout
      {
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Center
      };

      displayLabel = new Label
      {
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        VerticalOptions = LayoutOptions.Center,
        HorizontalTextAlignment = TextAlignment.End
      };

      mainStack.Children.Add(displayLabel);

      backspaceButton = new Button
      {
        Text = "\u21E6",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
        IsEnabled = false
      };

      backspaceButton.Clicked += OnBackspaceButtonClicked;

      mainStack.Children.Add(backspaceButton);

      StackLayout rowStack = null;

      for (int num = 1; num <= 10; num++)
      {
        if ((num - 1) % 3 == 0)
        {
          rowStack = new StackLayout
          {
            Orientation = StackOrientation.Horizontal
          };

          mainStack.Children.Add(rowStack);
        }

        var digitButton = new Button
        {
          Text = (num % 10).ToString(),
          FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
          StyleId = (num % 10).ToString(),
          HorizontalOptions = LayoutOptions.FillAndExpand
          
        };

        digitButton.Clicked += OnDigitButtonClicked;

        if (num == 10)
        {
          digitButton.HorizontalOptions = LayoutOptions.FillAndExpand;
        }

        rowStack.Children.Add(digitButton);
      }

      Content = mainStack;
    }

    private void OnDigitButtonClicked(object sender, EventArgs e)
    {
      var button = (Button)sender;

      displayLabel.Text += (String)button.StyleId;

      backspaceButton.IsEnabled = true;
    }

    private void OnBackspaceButtonClicked(object sender, EventArgs e)
    {
      var text = displayLabel.Text;

      displayLabel.Text = text.Substring(0, text.Length - 1);

      backspaceButton.IsEnabled = displayLabel.Text.Length > 0;
    }
  }
}
