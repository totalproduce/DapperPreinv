using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
 
namespace Bsdl.FreshTrade.UI.PreInv.Helpers
{
    public static class AutoCompleteBoxBehaviour
    {
        public static readonly DependencyProperty RightClickCommand = EventBehaviourFactory.CreateCommandExecutionEventBehaviour(AutoCompleteBox.MouseRightButtonUpEvent, "RightClickCommand", typeof(AutoCompleteBoxBehaviour));

        public static void SetRightClickCommand(DependencyObject o, ICommand value)
        {
            o.SetValue(RightClickCommand, value);
        }

        public static ICommand GetRightClickCommand(DependencyObject o)
        {
            return o.GetValue(RightClickCommand) as ICommand;
        }
    }
}