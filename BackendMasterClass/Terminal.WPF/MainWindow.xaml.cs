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

namespace Terminal.WPF
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

        private void TripBtn_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            TripPanel.Visibility = Visibility.Visible;
            TicketPanel.Visibility = Visibility.Collapsed;
            BusPanel.Visibility = Visibility.Collapsed;
            RoutePanel.Visibility = Visibility.Collapsed;
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Visible;
            TripPanel.Visibility = Visibility.Collapsed;
            TicketPanel.Visibility = Visibility.Collapsed;
            BusPanel.Visibility = Visibility.Collapsed;
            RoutePanel.Visibility = Visibility.Collapsed;
        }

        private void TicketBtn_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            TripPanel.Visibility = Visibility.Collapsed;
            TicketPanel.Visibility = Visibility.Visible;
            BusPanel.Visibility = Visibility.Collapsed;
            RoutePanel.Visibility = Visibility.Collapsed;
        }

        private void RouteBtn_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            TripPanel.Visibility = Visibility.Collapsed;
            TicketPanel.Visibility = Visibility.Collapsed;
            BusPanel.Visibility = Visibility.Collapsed;
            RoutePanel.Visibility = Visibility.Visible;
        }

        private void BusBtn_Click(object sender, RoutedEventArgs e)
        {
            HomePanel.Visibility = Visibility.Collapsed;
            TripPanel.Visibility = Visibility.Collapsed;
            TicketPanel.Visibility = Visibility.Collapsed;
            BusPanel.Visibility = Visibility.Visible;
            RoutePanel.Visibility = Visibility.Collapsed;
        }
    }
}