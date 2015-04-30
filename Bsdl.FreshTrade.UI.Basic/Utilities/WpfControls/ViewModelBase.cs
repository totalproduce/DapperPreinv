using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Threading;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public Dispatcher CurrentDispatcher
        {
            get { return Application.Current.Dispatcher; }
        }

        public void InvokeInUiThread(Action action, DispatcherPriority priority = DispatcherPriority.Render)
        {
            CurrentDispatcher.Invoke(priority, action);
        }

        public void BeginInvokeInUiThread(Action action, DispatcherPriority priority = DispatcherPriority.Render)
        {
            CurrentDispatcher.BeginInvoke(priority, action);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected string ExtractPropertyName<T>(Expression<Func<T>> property)
        {
            var lambda = (LambdaExpression)property;
            MemberExpression memberExpression;

            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression)lambda.Body;
            }

            return memberExpression.Member.Name;
        }

        protected void OnPropertyChanged<T>(Expression<Func<T>> property)
        {
            string propertyName = ExtractPropertyName(property);
            RaisePropertyChanged(propertyName);
        }
    }
}
