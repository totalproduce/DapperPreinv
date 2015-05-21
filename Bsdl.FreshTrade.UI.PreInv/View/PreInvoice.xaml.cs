using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.UI.Basic.Utilities;
using Bsdl.FreshTrade.UI.PreInv.PreInvService;
using Bsdl.FreshTrade.UI.PreInv.ViewModel;

namespace Bsdl.FreshTrade.UI.PreInv.View
{
    /// <summary>
    /// Interaction logic for PreInvoice.xaml
    /// </summary>
    public partial class PreInvoice
    {
        public PreInvoice()
		{
            InitializeComponent();
            
            Title = Title + " " + Globals.AppVersion;

			var dataContext = new PreInvMainViewModel();
            DataContext = dataContext;

            Closing += dataContext.OnWindowClosing;
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is PreInvMainViewModel)
            {
                (DataContext as PreInvMainViewModel).IsChanged = true;
            }
        }

        private void DatePicker_OnLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var dp = sender as DatePicker;
            if (dp == null) return;
            DateTime dt;

            if (DateTime.TryParseExact(dp.Text, "d", new DateTimeFormatInfo { ShortDatePattern = "ddMMyy" },
                DateTimeStyles.None, out dt))
            {
                dp.SelectedDate = dt;
            }

            if (DateTime.TryParseExact(dp.Text, "d", new DateTimeFormatInfo { ShortDatePattern = "ddMMyyyy" }, 
                DateTimeStyles.None, out dt))
            {
                dp.SelectedDate = dt;
            }
        }
    }
}
