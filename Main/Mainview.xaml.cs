using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Express_Inventory.Main
{
    public partial class Mainview : Window
    {
        public Mainview()
        {
            InitializeComponent();
        }

        #region [!] Form Controls (Move, Close, Minimize)

        private void MoveTheForm(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed) { DragMove(); }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExpandButton_Click(object sender, RoutedEventArgs e)
        {
            // Switch
            if (WindowState == WindowState.Normal) { WindowState = WindowState.Maximized; }
            else if (WindowState == WindowState.Maximized) { WindowState = WindowState.Normal; }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        #endregion

        #region [!] Form Opacity Controls
        private async void EnterMenu(object sender, MouseEventArgs e)
        {
            DetailedLeftMenu.Visibility = Visibility.Visible;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.1;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.3;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.4;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.5;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.6;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.7;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.8;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.9;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 1;
        }

        private async void ExitMenu(object sender, MouseEventArgs e)
        {
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.9;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.8;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.7;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.6;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.5;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.4;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.3;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.2;
            await Task.Delay(10);
            DetailedLeftMenu.Opacity = 0.1;
            await Task.Delay(10);
            DetailedLeftMenu.Visibility = Visibility.Collapsed;
        }
        #endregion
    }
}
