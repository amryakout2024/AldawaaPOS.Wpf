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
    public partial class MainWindow : Window
    {
        public MainWindow()
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
            LoginWindow loginWindow = new LoginWindow();

            //this.Hide();

            loginWindow.ShowDialog();
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
            MessageBox.Show("Open the path for the server folder");
        }

        private void backOffice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("need certain permissions");
        }
    }
}

/*
 * Process.Start("explorer.exe", "/select, c:\\teste");
 * To open a folder instead of selecting it just change /select to /open
 Syntax

      SHUTDOWN [logoff_option]  [/m \\Computer] [options]

logoff_option:
    /i         Display the GUI (must be the first option)
    /l         Log off. This cannot be used with /m or /d option
    /s         Shutdown
    /r         Shutdown and Restart
    /a         Abort a system shutdown.
               (only during the time-out period)
    /p         Turn off the local computer with no time-out or warning
               (only with /d)
    /h         Hibernate the local computer (only with /f )
    /e         Document the reason for an unexpected shutdown of a computer

Options:

   /m \\Computer  : A remote computer to shutdown.

   /t:xxx         : Time until system shutdown in seconds. 
                    The valid range is xxx=0-600 seconds. [default=30]
   /c "Msg"       : An optional shutdown message [Max 127 chars]

   /f             : Force running applications to close.
                    This will not prompt for File-Save in any open applications.
                    so will result in a loss of all unsaved data!!!

   /d u:xx:yy     : List a USER reason code for the shutdown. 
   /d P:xx:yy     : List a PLANNED reason code for the shutdown.
                     xx Specifies the major reason code (0-255)
                     yy Specifies the minor reason code (0-65536)
 */