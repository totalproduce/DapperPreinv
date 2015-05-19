using System;
using System.Globalization;
using System.Windows;

namespace Bsdl.FreshTrade.Error
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window
    {
        private const int LongHeight = 570;
        private const int ShortHeight = 295;
        private const string ShowDetailsText = "Show Details";
        private const string HideDetailsText = "Hide Details";

        public ErrorWindow()
        {
            InitializeComponent();

            btnDetails.Content = ShowDetailsText.ToString(CultureInfo.CurrentCulture);
            this.Height = ShortHeight;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current.MainWindow.GetType().Assembly.GetName().Name;
            Title = "Error Message";

            // Log the error in the DB
            try
            {
                if (AppError.ErrorType != ErrorType.Info)
                {
                    Error.Service.LogError();
                }
            }
            catch (Exception ex)
            {
                string logError = "Problem logging this error in the database." + Environment.NewLine +
                                  Environment.NewLine;
                logError += ex.Message;
                MessageBox.Show(logError, "Problem logging error");
            }

            txtClassName.Text = AppError.ClassName;
            txtMethod.Text = AppError.MethodName;
            txtErrorType.Text = AppError.ErrorType.ToString();

            string message = AppError.Message + Environment.NewLine + Environment.NewLine;

            if (!string.IsNullOrWhiteSpace(AppError.OracleErrorCode))
            {
                message += AppError.OracleErrorCode + Environment.NewLine + Environment.NewLine;
            }

            if (!string.IsNullOrWhiteSpace(AppError.OracleErrorSql))
            {
                message += AppError.OracleErrorSql + Environment.NewLine + Environment.NewLine;
            }

            txtMessage.Text = message;
            txtStackTrace.Text = AppError.StackTrace;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            if (btnDetails.Content.ToString() == ShowDetailsText.ToString(CultureInfo.CurrentCulture))
            {
                this.Height = LongHeight;
                btnDetails.Content = HideDetailsText.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                this.Height = ShortHeight;
                btnDetails.Content = ShowDetailsText.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void FormClose(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            Close();
        }

    }

}
