using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bsdl.FreshTrade.UI.PreInv.View
{
	/// <summary>
	/// Interaction logic for SplashScreen.xaml
	/// </summary>
	public partial class SplashScreen : Window
	{
		private static SplashScreen _splash = new SplashScreen();

		// To refresh the UI immediately
		private static void Refresh(DependencyObject obj)
		{
			obj.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
				(Action)delegate { });
		}

		public SplashScreen()
		{
			InitializeComponent();
		}

		public static void ShowSplash()
		{
			_splash.Show();
		}

		public static void HideSplash()
		{
			_splash.Close();
		}

		public static string Text
		{
			set
			{
				_splash.statuslbl.Content = value;
				Refresh(_splash.statuslbl);
			}
			get
			{
				return _splash.statuslbl.Content as string;
			}
		}
	}
}
