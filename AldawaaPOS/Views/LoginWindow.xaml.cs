using AldawaaPOS.ViewModels;
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
        
        LoginVM loginVM { get; set; }

        public LoginWindow(MainWindow mainWindow)
        {
            loginVM = new LoginVM();
            DataContext = loginVM;
            InitializeComponent();

            Username.Focus();
            _mainWindow = mainWindow;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
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

        private void EmpId_GotFocus(object sender, RoutedEventArgs e)
        {
            loginVM.IsEmpIdFocused = true;
            loginVM.IsPasswordFocused = false;
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            loginVM.IsPasswordFocused = true;
            loginVM.IsEmpIdFocused = false;
        }

    }
}
