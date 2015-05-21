using System;
using System.ComponentModel;
using System.Configuration;
using System.ServiceModel;
using System.Threading;
using System.Windows;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.UI.Basic.Exceptions;

namespace Bsdl.FreshTrade.UI.Basic.Utilities
{
    public static class FreshTrade
    {
        private static void ReadCommandlineParameters()
        {
            // Throw error if no command-line params (1st param is .exe name, so ignore it)
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 1)
            {
                var ex = new StartupNoDbIdException();
                //AppError.SetError(ex, Environment.StackTrace, ErrorType.Fatal);
                throw ex;
            }
            int dbID;
            if (!int.TryParse(args[1], out dbID))
            {
                var ex = new StartupInvaildDbIdException();
                //AppError.SetError(ex, Environment.StackTrace, ErrorType.Fatal);
                throw ex;
            }
            Globals.DbID = dbID;
        }

        public static bool Startup(string errorMessageCaption)
        {
            bool canInitialise = true;
            int attempt = 0;
            string exMessage = string.Empty;
            ReadCommandlineParameters();

            while (attempt++ < 3)
            {
                try
                {
                    // Get user details
                    string userLogon = Environment.UserName.ToUpper().Trim();
                    //try
                    //{
                    var userServiceClient = new UserServiceReference.UserServiceClient();
                    try
                    {
                        Globals.FreshTradeUser = (IDTOUser) userServiceClient.AuthenticateUser(userLogon, Globals.DbID);
                    }
                    finally
                    {
                        userServiceClient.Close();
                    }
                    if (Globals.FreshTradeUser == null)
                    {
                        var ex = new StartupInvalidUserException();
                        //AppError.SetError(ex, Environment.StackTrace, ErrorType.Fatal);
                        throw ex;
                    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                    //    throw;
                    //}

                    //AppError.ConnectionString = Globals.ConnectionString;
                    //AppError.FreshTradeUserId = Globals.FreshTradeUser.Id;

                    break;
                }
                catch (Exception ex)
                {
                    canInitialise = false;
                    exMessage = ex.Message;

                    Thread.Sleep(3000);
                }
            }

            if (canInitialise == false)
            {
                MessageBox.Show(exMessage, errorMessageCaption, MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (canInitialise)
            {
                var bw = new BackgroundWorker();
                bw.DoWork += Ping;
                bw.RunWorkerAsync();
            }

            return canInitialise;
        }

        private static void Ping(object sender, DoWorkEventArgs doWorkEventArgs)
        {

            int periodPing;
            int.TryParse(ConfigurationManager.AppSettings["PingPeriod"], out periodPing); //returns 0 if fails

            periodPing = (periodPing <= 0 ? 5 : periodPing)*60*1000;
            while (true)
            {
                Thread.Sleep(periodPing);

                var userServiceClient = new UserServiceReference.UserServiceClient();
                try
                {
                    userServiceClient.Ping();
                }
                catch (Exception)
                {
                }
                finally
                {
                    userServiceClient.Close();
                }

            }
        }
    }
}
