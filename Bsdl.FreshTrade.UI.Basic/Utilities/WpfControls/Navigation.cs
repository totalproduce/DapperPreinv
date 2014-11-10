using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls.InputSimulatorFolder;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls
{
    public static class Navigation
    {
        private static readonly RoutedUICommand doNothing = new RoutedUICommand("Do Nothing", "DoNothing", typeof(Navigation));
        public static RoutedUICommand DoNothing { get { return doNothing; } }

        private static readonly RoutedUICommand moveLeft = new RoutedUICommand("Move Left", "MoveLeft", typeof(Navigation));
        public static RoutedUICommand MoveLeft { get { return moveLeft; } }

        private static readonly RoutedUICommand moveRight = new RoutedUICommand("Move Right", "MoveRight", typeof(Navigation));
        public static RoutedUICommand MoveRight { get { return moveRight; } }

        public static readonly RoutedUICommand MoveDown = new RoutedUICommand("Move Down", "MoveDown", typeof(Window));
        public static readonly RoutedUICommand MoveUp = new RoutedUICommand("Move Up", "MoveUp", typeof(Window));

        public static void MoveBack()
        {
            if (Keyboard.PrimaryDevice != null)
            {
                if (Keyboard.PrimaryDevice.ActiveSource != null)
                {
                    InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.SHIFT, VirtualKeyCode.TAB);
                }
            }
        }

        public static void MoveForward()
        {
            if (Keyboard.PrimaryDevice != null)
            {
                if (Keyboard.PrimaryDevice.ActiveSource != null)
                {
                    var e1 = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.Tab)
                    {
                        RoutedEvent = Keyboard.KeyDownEvent
                    };
                    InputManager.Current.ProcessInput(e1);
                }
            }
        }


        public static void MoveUpOrDown(object sender, ExecutedRoutedEventArgs e, Window window, List<string> controlChain)
        {
            string currentControl = GetControlName(e);

            if (string.IsNullOrWhiteSpace(currentControl))
            {
                return;
            }

            for (int i = 0; i < controlChain.Count - 1; i++)
            {
                // If control name in list isn't current control, skip to next item in list
                string listControl = controlChain[i];
                if (listControl != currentControl)
                {
                    continue;
                }

                // If name of next control in the chain is blank, skip to next item in list
                string controlToPutFocusOn = controlChain[i + 1];
                if (string.IsNullOrWhiteSpace(controlToPutFocusOn))
                {
                    continue;
                }

                // Put focus on putFocusOn
                Control myControl = (Control)window.FindName(controlToPutFocusOn);
                myControl.Focus();
                break;
            }
        }

        private static string GetControlName(ExecutedRoutedEventArgs e)
        {
            // TODO: may need to change Source to OriginalSource
            var source = e.Source;
            // var originalSource = e.OriginalSource;

            TextBox textBox = source as TextBox;
            if (textBox != null)
            {
                return textBox.Name;
            }

            CheckBox checkBox = source as CheckBox;
            if (checkBox != null)
            {
                return checkBox.Name;
            }

            Button button = source as Button;
            if (button != null)
            {
                return button.Name;
            }

            Label label = source as Label;
            if (label != null)
            {
                return label.Name;
            }

            // TODO: Put checks for other controls here if required

            return string.Empty;
        }

    }
}
