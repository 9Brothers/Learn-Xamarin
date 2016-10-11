using Learn.Chapters.C02;
using Learn.Chapters.C03;
using Learn.Chapters.C04_Scrolling_the_stack;
using Learn.Chapters.C05_Dealing_with_sizes;
using Learn.Chapters.C06_Button_clicks;
using Learn.Classes.C04_Scrolling_the_stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Learn
{
  public class App : Application
  {
    const String displayLabelText = "displayLabelText";

    public App()
    {
      #region Chapter 2 - Anatomy of an app
      //MainPage = new Hello();
      //MainPage = new GreetingsPage();
      #endregion

      #region Chapter 3 - Deeper into text
      //MainPage = new BaskervillesPage();
      //MainPage = new VariableFormattedTextPage();
      //MainPage = new VariableFormattedParagraphPage();
      //MainPage = new NamedFontSizesPage();
      #endregion

      #region Chapter 4 - Scrolling the stack
      //MainPage = new ColorLoopPage();
      //MainPage = new ColorListPage();
      //MainPage = new ReflectedColorsPage();
      //MainPage = new VerticalOptionsDemoPage();
      //MainPage = new FramedTextPage();
      //MainPage = new SizedBoxViewPage();
      //MainPage = new ColorBlocksPage();
      //MainPage = new BlackCatPage();      
      #endregion

      #region Chapter 5 - Dealing with sizes
      //MainPage = new WhatSizePage();
      //MainPage = new MetricalBoxViewPage();
      //MainPage = new FontSizesPage();
      //MainPage = new EstimatedFontSizePage();
      //MainPage = new FitToSizeClockPage();
      //MainPage = new AccessibilityTestPage();
      //MainPage = new EmpiricalFontSizePage();
      #endregion

      #region Chapter 6 - Button clicks
      //MainPage = new ButtonLoggerPage();
      //MainPage = new TwoButtonsPage();
      //MainPage = new ButtonLambdasPage();
      //MainPage = new SimplestKeypadPage();
      if (Properties.ContainsKey(displayLabelText))
      {
        DisplayLabelText = (string)Properties[displayLabelText];
      }
      MainPage = new PersistentKeypadPage();
      #endregion
    }

    public String DisplayLabelText { get; set; }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
      Properties[displayLabelText] = DisplayLabelText;
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
