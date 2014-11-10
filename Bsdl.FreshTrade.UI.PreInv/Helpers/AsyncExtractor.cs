using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Bsdl.FreshTrade.UI.PreInv.Helpers
{
    public class AsyncExtractor<T1, T2> where T1 : IDisposable, new()
    {
        private Func<T1, T2> m_MainAction;
        private Action<T2> m_FinishCallback;
        private Func<T1, bool> m_CanProgressFunc;
        private Action<T1> m_AbortAction;
        private T1 m_StateObject;
        private T1 m_HelperObject;
        private T2 m_MainActionResult;
        private Timer m_Timer;
        private Task m_MainTask;
        private volatile bool m_StopRequested;

        private const int DELAY = 500;

        public AsyncExtractor(Func<T1, T2> mainAction, Action<T2> finishAction, Func<T1, bool> progressCallback, Action<T1> abortAction)
        {
            m_StateObject = new T1();
            m_HelperObject = new T1();

            m_MainAction = mainAction;
            m_FinishCallback = finishAction;
            m_CanProgressFunc = progressCallback;
            m_AbortAction = abortAction;
        }

        public void BeginExecute()
        {
            m_Timer = new Timer(TimeExpired, null, Timeout.Infinite, Timeout.Infinite);

            m_MainTask = Task.Factory.StartNew(() =>
            {
                m_MainActionResult = m_MainAction(m_StateObject);
            });

            m_StopRequested = false;
            m_Timer.Change(DELAY, Timeout.Infinite);
        }

        public void Abort()
        {
            m_StopRequested = true;
        }

        private void TimeExpired(object state)
        {
            if (!m_StopRequested && m_CanProgressFunc(m_HelperObject))
            {
                m_Timer.Change(DELAY, Timeout.Infinite);
            }
            else
            {
                if (!m_StopRequested && m_MainTask != null)
                {
                    try
                    {
                        m_MainTask.Wait();
                    }
                    catch (AggregateException e)
                    {
                        Action errorMessageBox =
                            () =>
                            {
                                string message = e.Message;
                                foreach (var innerEx in e.InnerExceptions)
                                {
                                    message += "\n" + innerEx.Message;
                                }

                                MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            };

                        Abort();

                        Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, errorMessageBox);
                    }
                    catch (Exception e)
                    {
                        Action errorMessageBox =
                            () => MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                        Abort();

                        Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, errorMessageBox);
                    }
                }
                else
                {
                    m_AbortAction(m_HelperObject);
                }

                m_StateObject.Dispose();
                m_FinishCallback(m_MainActionResult);
            }
        }
    }
}
