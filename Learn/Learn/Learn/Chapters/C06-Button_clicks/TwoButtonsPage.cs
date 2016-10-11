using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C06_Button_clicks
{
  class TwoButtonsPage : ContentPage
  {
    Button addButton, removeButton;
    StackLayout loggerLayout = new StackLayout();

    public TwoButtonsPage()
    {
      addButton = new Button
      {
        Text = "Add",
        HorizontalOptions = LayoutOptions.FillAndExpand
      };

      addButton.Clicked += OnAddButtonClicked;

      removeButton = new Button
      {
        Text = "Remove",
        HorizontalOptions = LayoutOptions.FillAndExpand,
        IsEnabled = false
      };

      removeButton.Clicked += OnRemoveButtonClicked;

      Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

      Content = new StackLayout
      {
        Children =
        {
          new StackLayout
          {
            Orientation = StackOrientation.Horizontal,
            Children =
            {
              addButton,
              removeButton
            }
          },
          new ScrollView
          {
            VerticalOptions = LayoutOptions.FillAndExpand,
            Content = loggerLayout
          }
        }
      };
    }

    private void OnRemoveButtonClicked(object sender, EventArgs e)
    {
      loggerLayout.Children.RemoveAt(0);

      removeButton.IsEnabled = loggerLayout.Children.Count > 0;
    }

    private void OnAddButtonClicked(object sender, EventArgs e)
    {
      loggerLayout.Children.Add(new Label
      {
        Text = "Button clicked at " + DateTime.Now.ToString("T")
      });

      removeButton.IsEnabled = loggerLayout.Children.Count > 0;
    }
  }
}
