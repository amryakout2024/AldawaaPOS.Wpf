using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for NaphiesWindow.xaml
    /// </summary>
    public partial class NaphiesWindow : Window
    {
        public NaphiesWindow()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void FaClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void FaMini_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (nw.WindowState == WindowState.Normal)
            {
                nw.WindowState = WindowState.Minimized;
            }
            else if (nw.WindowState == WindowState.Maximized)
            {
                nw.WindowState = WindowState.Minimized;
            }

        }

        private void FaMax_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (nw.WindowState == WindowState.Normal)
            {
                nw.WindowState = WindowState.Maximized;
            }
            else if (nw.WindowState == WindowState.Maximized)
            {
                nw.WindowState = WindowState.Normal;
            }

        }

        private void mainGrid_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void mainGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (nw.WindowState == WindowState.Normal)
                {
                    nw.WindowState = WindowState.Maximized;
                }
                else if (nw.WindowState == WindowState.Maximized)
                {
                    nw.WindowState = WindowState.Normal;
                }

            }
        }
    }
}
