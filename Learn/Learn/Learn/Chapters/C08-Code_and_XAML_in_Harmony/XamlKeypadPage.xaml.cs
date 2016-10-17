using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Learn.Chapters.C08_Code_and_XAML_in_Harmony
{
  public partial class XamlKeypadPage : ContentPage
  {
    App app = Application.Current as App;
    public XamlKeypadPage()
    {
      InitializeComponent();

      displayLabel.Text = app.DisplayLabelText;

      backspaceButton.IsEnabled =
        displayLabel.Text != null &&
        displayLabel.Text.Length > 0;
    }

    void OnDigitButtonClicked(object sender, EventArgs e)
    {
      var button = (Button)sender;
      displayLabel.Text += (String)button.StyleId;
      backspaceButton.IsEnabled = true;

      app.DisplayLabelText = displayLabel.Text;
    }

    void OnBackspaceButtonClicked(object sender, EventArgs e)
    {
      var text = displayLabel.Text;
      displayLabel.Text = text.Substring(0, text.Length - 1);
      backspaceButton.IsEnabled = displayLabel.Text.Length > 0;
      app.DisplayLabelText = displayLabel.Text;
    }
  }
}
