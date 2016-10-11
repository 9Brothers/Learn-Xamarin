using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C05_Dealing_with_sizes
{
  public class EmpiricalFontSizePage : ContentPage
  {
    Label label;

    public EmpiricalFontSizePage()
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
      var view = (View)sender;

      if (view.Width <= 0 || view.Height <= 0) return;

      label.Text =
        "This is a paragraph of text displayed with " +
        "a FontSize value of ?? that is empirically " +
        "calculated in a loop within the SizeChanged " +
        "handler of the Label's container. This technique " +
        "can be tricky: You don't want to get into " +
        "an infinite loop by triggering a layout pass " +
        "with every calculation. Does it work?";

      var lowerFontCalc = new FontCalc(label, 10, view.Width);
      var upperFontCalc = new FontCalc(label, 100, view.Width);

      while (upperFontCalc.FontSize - lowerFontCalc.FontSize > 1)
      {
        var fontSize = (lowerFontCalc.FontSize + upperFontCalc.FontSize) / 2;

        var newFontCalc = new FontCalc(label, fontSize, view.Width);

        if (newFontCalc.TextHeight > view.Height) upperFontCalc = newFontCalc;
        else lowerFontCalc = newFontCalc;
      }

      label.FontSize = lowerFontCalc.FontSize;
      label.Text = label.Text.Replace("??", label.FontSize.ToString("F0"));
    }

    
  }

  struct FontCalc
  {
    public FontCalc(Label label, double fontSize, double containerWidth) : this()
    {
      FontSize = fontSize;

      label.FontSize = fontSize;

      var sizeRequest = label.Measure(containerWidth, double.PositiveInfinity);

      TextHeight = sizeRequest.Request.Height;
    }

    public Double FontSize { get; private set; }

    public Double TextHeight { get; private set; }
  }
}
