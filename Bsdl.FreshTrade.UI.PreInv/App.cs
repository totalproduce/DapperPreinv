using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using Bsdl.FreshTrade.UI.Basic.Utilities;
using Bsdl.FreshTrade.UI.PreInv.View;
using Application = System.Windows.Application;
using SplashScreen = Bsdl.FreshTrade.UI.PreInv.View.SplashScreen;

namespace Bsdl.FreshTrade.UI.PreInv
{
    public class EntryPoint
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var manager = new SingleInstanceApplicationWrapper<App>();
            manager.Run(args);
        }
    }

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public class App : SingleInstanceApplication
    {
        private PreInvoice _mainWindow;

        protected override void OnStartup(StartupEventArgs e)
        {
            DispatcherUnhandledException += App_OnDispatcherUnhandledException;

            SplashScreen.ShowSplash();
            SplashScreen.Text = "Contacting server";
            if (!Bsdl.FreshTrade.UI.Basic.Utilities.FreshTrade.Startup("Error Loading Account Lookup"))
            {
                Shutdown();
            }
            else
            {
                //AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
                _mainWindow = new PreInvoice();
                _mainWindow.Show();
                SplashScreen.HideSplash();
            }
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception) e.ExceptionObject;
            System.Windows.Forms.MessageBox.Show(
                string.Format("An unhandled application domain exception occured", exception.Message),
                (e.IsTerminating ? "Fatal Error" : "Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.Exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public override void Activate()
        {
            if (_mainWindow != null)
            {
                if (_mainWindow.WindowState == WindowState.Minimized)
                {
                    _mainWindow.WindowState = WindowState.Normal;
                }
                _mainWindow.Activate();
            }
        }
    }
}
