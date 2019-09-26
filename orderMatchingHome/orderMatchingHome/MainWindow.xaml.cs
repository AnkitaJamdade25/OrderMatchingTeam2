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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace orderMatchingHome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frameHome.Source = new Uri("Dashboard.xaml", UriKind.Relative);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
             frameHome.Source = new Uri("Trade.xaml", UriKind.Relative);
         //   frameHome.Content = new Trade();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
             frameHome.Source = new Uri("Filled.xaml", UriKind.Relative);
            // frameHome.Content = new Filled();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            frameHome.Source = new Uri("TransacLog.xaml", UriKind.Relative);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            frameHome.Source = new Uri("Pending.xaml", UriKind.Relative);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            frameHome.Source = new Uri("Dashboard.xaml", UriKind.Relative);
        }
    }
}
