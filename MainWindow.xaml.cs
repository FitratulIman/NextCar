using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
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

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("OnStartButtonClicke");
        }

        private void OnDoorOpenButtonClicked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("OnDoorOpenButtonClicked");
        }

        private void OnLockDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("OnLockDoorButtonClicked");
        }

        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("OnAccuButtonClicked");
        }
    }
}
