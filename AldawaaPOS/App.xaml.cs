using AldawaaPOS.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AldawaaPOS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //MainWindow = new MainWindow("9744");
            MainWindow = new StartingWindow();
            //MainWindow = new NaphiesWindow();

            MainWindow.Show();
        }
    }

}
