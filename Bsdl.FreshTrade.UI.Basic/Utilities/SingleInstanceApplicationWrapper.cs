using System;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;

namespace Bsdl.FreshTrade.UI.Basic.Utilities
{
    public class SingleInstanceApplicationWrapper<T> : WindowsFormsApplicationBase where T : SingleInstanceApplication, new()
    {
        private SingleInstanceApplication _app;

        public SingleInstanceApplicationWrapper()
        {
            IsSingleInstance = true;
        }
 
        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
        {
            // First time app is launched
            try
            {
                _app = new T();
                _app.Run();
            }
            catch(Exception)
            {
                
            }

            return false;
        }
 
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            // Subsequent launches
            base.OnStartupNextInstance(eventArgs);
            _app.Activate();
        }
    }

    public abstract class SingleInstanceApplication : Application
    {
        public abstract void Activate();
    }
}
