using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        private readonly Action<object> _methodToExecute;
        private readonly Func<bool> _canExecuteEvaluator;
        public RelayCommand(Action<object> methodToExecute, Func<bool> canExecuteEvaluator)
        {
            _methodToExecute = methodToExecute;
            _canExecuteEvaluator = canExecuteEvaluator;
        }
        public RelayCommand(Action<object> methodToExecute)
            : this(methodToExecute, null)
        {
        }
        public bool CanExecute(object parameter)
        {
            if (_canExecuteEvaluator == null)
            {
                return true;
            }
            var result = _canExecuteEvaluator.Invoke();
            return result;
        }
        public void Execute(object parameter)
        {
            try
            {
                _methodToExecute.Invoke(parameter);
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

                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, errorMessageBox);
            }
            catch (Exception e)
            {
                Action errorMessageBox =
                    () => MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, errorMessageBox);
            }
            
            
        }
    }
}
