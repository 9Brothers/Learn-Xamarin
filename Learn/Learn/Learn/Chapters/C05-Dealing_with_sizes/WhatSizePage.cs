using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C05_Dealing_with_sizes
{
  class WhatSizePage : ContentPage
  {
    Label label;

    public WhatSizePage()
    {
      label = new Label
      {
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };

      Content = label;

      SizeChanged += OnPageSizeChanged;
    }

    private void OnPageSizeChanged(object sender, EventArgs e)
    {
      label.Text = String.Format($"{Width} \u00D7 {Height}");
    }
  }
}
