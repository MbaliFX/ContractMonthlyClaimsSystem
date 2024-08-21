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

namespace CMCS_Part1
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

        private void lecturerButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Visible;
            coordinator_page.Visibility = Visibility.Hidden;    
        }

        private void coordinatorButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Visible;
        }

        private void managerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
        }
    }
}