using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Learn.Chapters.C08_Code_and_XAML_in_Harmony
{
  public partial class ColorView : ContentView
  {
    String colorName;
    ColorTypeConverter colorTypeConv = new ColorTypeConverter();

    public ColorView()
    {
      InitializeComponent();
    }

    public String ColorName
    {
      get
      {
        return colorName;
      }
      set
      {
        colorName = value;
        colorNameLabel.Text = value;

        var color = (Color)colorTypeConv.ConvertFromInvariantString(colorName);
        boxView.Color = color;
        colorValueLabel.Text =
          String.Format("{0:X2}-{1:X2}-{2:X2}",
            (Int32)(255 * color.R),
            (Int32)(255 * color.G),
            (Int32)(255 * color.B));
      }
    }
  }
}
