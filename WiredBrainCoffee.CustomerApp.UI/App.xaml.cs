﻿using Autofac;
using System;
using System.Windows;
using WiredBrainCoffee.CustomerApp.UI.Startup;

namespace WiredBrainCoffee.CustomerApp.UI
{
  public partial class App : Application
  {
    private void Application_Startup(object sender, StartupEventArgs e)
    {
      var bootstrapper = new Bootstrapper();
      var container = bootstrapper.Bootstrap();

      var mainWindow = container.Resolve<MainWindow>();
      mainWindow.Show();
    }

    private void Application_DispatcherUnhandledException(object sender,
      System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
      MessageBox.Show("Unexpected error occured. Please inform the admin."
        + Environment.NewLine
        + Environment.NewLine + e.Exception.Message, "Unexpected error");

      e.Handled = true;
    }
  }
}
