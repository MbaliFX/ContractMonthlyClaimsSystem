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
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void coordinatorButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Visible;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void managerButton_Click(object sender, RoutedEventArgs e)
        {
            manager_page.Visibility = Visibility.Visible;
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void dashboardButton2_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void trackClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Visible;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void dashboardButton3_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;  
        }

        private void newClaimButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Visible;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Visible;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;   
        }

        private void reviewClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Visible;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void newClaimCoordinatorButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Visible;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility= Visibility.Hidden;
            reviewClaimsManager_page.Visibility= Visibility.Hidden;
        }

        private void dashboardButton4_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility= Visibility.Hidden;
            reviewClaimsManager_page.Visibility= Visibility.Hidden;
        }

        private void dashboardButton5_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void newClaimManagerButton_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Hidden;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Visible;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility = Visibility.Hidden;
        }

        private void dashboardButton6_Click(object sender, RoutedEventArgs e)
        {
            landing_page.Visibility = Visibility.Visible;
            lecturers_page.Visibility = Visibility.Hidden;
            coordinator_page.Visibility = Visibility.Hidden;
            manager_page.Visibility = Visibility.Hidden;
            trackClaims_page.Visibility = Visibility.Hidden;
            reviewClaims_page.Visibility = Visibility.Hidden;
            reviewClaimsManager_page.Visibility= Visibility.Hidden;
        }
    }
}