using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn.Chapters.C06_Button_clicks
{
  class ButtonLoggerPage : ContentPage
  {
    StackLayout loggerLayout = new StackLayout();
    public ButtonLoggerPage()
    {
      var logButton = new Button
      {
        Text = "Log the Click Time",        
      };
      
      logButton.Clicked += OnLogButtonClicked;

      var clearLogsButton = new Button
      {
        Text = "Clear logs"
      };

      clearLogsButton.Clicked += OnClearLogsButtonClicked;

      Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

      Content = new StackLayout
      {
        Children =
        {          
          logButton,
          clearLogsButton,
          new ScrollView
          {
            VerticalOptions = LayoutOptions.FillAndExpand,
            Content = loggerLayout
          }
        }
      };
    }

    private void OnClearLogsButtonClicked(object sender, EventArgs e)
    {
      loggerLayout.Children.Clear();
    }

    private void OnLogButtonClicked(object sender, EventArgs e)
    {
      loggerLayout.Children.Add(new Label
      {
        Text = "Button clicked at " + DateTime.Now.ToString("T")
      });
    }
  }
}
