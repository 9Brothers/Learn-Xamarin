using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C05_Dealing_with_sizes
{
  class EstimatedFontSizePage : ContentPage
  {
    Label label;
    public EstimatedFontSizePage()
    {
      label = new Label();

      Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

      var contentView = new ContentView
      {
        Content = label
      };

      contentView.SizeChanged += OnContentViewSizeChanged;

      Content = contentView;
    }

    private void OnContentViewSizeChanged(object sender, EventArgs e)
    {
      var text =
        "A default system font with a font size of S " +
        "has a line height of about ({0:F1} * S) and an " + 
        "average character width of about ({1:F1} * S). " + 
        "On this page, which has a width of {2:F0} and a " + 
        "height of {3:F0}, a font size of ?1 should " + 
        "comfortably render the ??2 characters in this " + 
        "paragraph with ?3 lines and about ?4 characters " + 
        "per line. Does it work?";

      var view = (View)sender;

      var lineHeight = Device.OnPlatform(1.2, 1.2, 1.3);
      var charWidth = 0.5;

      text = String.Format(text, lineHeight, charWidth, view.Width, view.Height);
      var charCount = text.Length;

      var fontSize = (int)Math.Sqrt(view.Width * view.Height / (charCount * lineHeight * charWidth));

      var lineCount = (int)(view.Height / (lineHeight * fontSize));

      var charsPerLine = (int)(view.Width / (charWidth * fontSize));

      text = text.Replace("?1", fontSize.ToString());
      text = text.Replace("??2", charCount.ToString());
      text = text.Replace("?3", lineCount.ToString());
      text = text.Replace("?4", charsPerLine.ToString());

      label.Text = text;
      label.FontSize = fontSize;
    }
  }
}
