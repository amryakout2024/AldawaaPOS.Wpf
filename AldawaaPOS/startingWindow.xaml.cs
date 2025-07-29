using AldawaaPOS.ViewModels;
using AldawaaPOS.Views;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AldawaaPOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StartingWindow : Window
    {
        public StartingWindow()
        {
            InitializeComponent();
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

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (mw.WindowState == WindowState.Normal)
                {
                    mw.WindowState = WindowState.Maximized;
                }
                else if (mw.WindowState == WindowState.Maximized)
                {
                    mw.WindowState = WindowState.Normal;
                }

            }
        }

        private void FaClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void FaMini_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (mw.WindowState == WindowState.Normal)
            {
                mw.WindowState = WindowState.Minimized;
            }
            else if (mw.WindowState == WindowState.Maximized)
            {
                mw.WindowState = WindowState.Minimized;
            }

        }

        private void FaMax_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (mw.WindowState == WindowState.Normal)
            {
                mw.WindowState = WindowState.Maximized;
            }
            else if (mw.WindowState == WindowState.Maximized)
            {
                mw.WindowState = WindowState.Normal;
            }

        }

        private void shoutDown_Click(object sender, RoutedEventArgs e)
        {
            var cmd = new ProcessStartInfo("shutdown.exe", "-s -t 0");
            cmd.CreateNoWindow = true;
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = false;
            Process.Start(cmd);
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            var cmd = new ProcessStartInfo("shutdown.exe", "-r -t 0");
            cmd.CreateNoWindow = true;
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = false;
            Process.Start(cmd);

        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(this);

            //LoginWindow loginWindow = new LoginWindow(this)
            //{
            //    DataContext = new LoginVM()
            //};

            this.Hide();

            loginWindow.Show();
        }

        private void controlPanel_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("control.exe");

            //or this
            //Process.Start(new ProcessStartInfo() 
            //{
            //    FileName = "control.exe",
            //    UseShellExecute = true
            //});
        }

        private void updateBatch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open the path for the ftp folder");
        }

        private void backOffice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("need certain permissions");
        }
    }
}
