using Learn.Chapters.C02;
using Learn.Chapters.C03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Learn
{
  public class App : Application
  {
    public App()
    {
      //MainPage = new Hello();
      MainPage = new GreetingsPage();
      //MainPage = new BaskervillesPage();
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
