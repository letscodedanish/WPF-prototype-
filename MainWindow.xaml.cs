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

namespace job_provider
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

        private void Login_click_(object sender, RoutedEventArgs e)
        {
            main_page.Opacity = 0.5;
            LOG_IN.Visibility = Visibility.Visible;

        }

        private void Cancel_click_(object sender, RoutedEventArgs e)
        {
            main_page.Opacity = 1;
            LOG_IN.Visibility = Visibility.Hidden;


        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            main_page.Opacity = 1;
            Sign_up.Visibility = Visibility.Hidden;
        }

        private void signup_click(object sender, RoutedEventArgs e)
        {
            main_page.Opacity = 0.5;
            Sign_up.Visibility = Visibility.Visible;

        }

        private void Login_click(object sender, RoutedEventArgs e)
        {
            string correct_employee_id = "admin";
            string correct_password = "12345";

            string email_id = email.Text;
            string Employee_password = password.Text;

            if (email_id == "" || Employee_password == "")
            {

                MessageBox.Show("please fill username password both", "Error");
            }
            else
            {
                if (email_id == correct_employee_id && Employee_password == correct_password)
                {
                    Hide();
                    dashboard dashboard = new dashboard();
                    dashboard.Show();

                }
                else
                {
                    MessageBox.Show("incorrect if & password", "Error");

                }
            }
        }
    }
}