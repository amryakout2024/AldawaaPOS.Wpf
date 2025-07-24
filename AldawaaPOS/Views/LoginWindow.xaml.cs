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

namespace AldawaaPOS.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly MainWindow _mainWindow;
        
        public LoginWindow()
        {
            
        }

        public LoginWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            Username.Focus();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    this.DragMove();
                }
            }
            catch (Exception)
            {
            }
        }

        private void FaClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainWindow.Show();
            this.Close();
        }

        private void FaMini_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lw.WindowState == WindowState.Normal)
            {
                lw.WindowState = WindowState.Minimized;
            }
            else if (lw.WindowState == WindowState.Maximized)
            {
                lw.WindowState = WindowState.Minimized;
            }

        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                Password.Focus();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show("Test"); ;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test"); ;
        }

        private void fwKeyboard_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
