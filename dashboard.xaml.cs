using Microsoft.VisualBasic.FileIO;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace job_provider
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Window
    {
        public dashboard()
        {

            InitializeComponent();
            vacancy_data_load();
            organisation_data_load();
            client_data_load();
        }


  
   

      
        private void Load_partner_data_Click(object sender, RoutedEventArgs e)
        {
            ADD_VACANCY.Visibility = Visibility.Hidden;
            partner_registration.Visibility = Visibility.Hidden;
            add_client.Visibility = Visibility.Hidden;
            pop_up_window.Visibility = Visibility.Hidden;
            available_vacancy_detail_list.Visibility = Visibility.Hidden;
            client_detail_list.Visibility = Visibility.Hidden;
            partner_detail_list.Visibility = Visibility.Visible;
        }

        private void our_client_data_Click(object sender, RoutedEventArgs e)
        {
            ADD_VACANCY.Visibility = Visibility.Hidden;
            partner_registration.Visibility = Visibility.Hidden;
            add_client.Visibility = Visibility.Hidden;
            partner_detail_list.Visibility = Visibility.Hidden;
            available_vacancy_detail_list.Visibility = Visibility.Hidden;
            pop_up_window.Visibility = Visibility.Hidden;
            client_detail_list.Visibility = Visibility.Visible;
        }

        private void available_vacancy_btn_Click(object sender, RoutedEventArgs e)
        {
            ADD_VACANCY.Visibility = Visibility.Hidden;
            partner_registration.Visibility = Visibility.Hidden;
            add_client.Visibility = Visibility.Hidden;
            partner_detail_list.Visibility = Visibility.Hidden;
            pop_up_window.Visibility = Visibility.Hidden;
            client_detail_list.Visibility = Visibility.Hidden;
            available_vacancy_detail_list.Visibility = Visibility.Visible;

        }



        private void organisation_data_load()
        {
            List<Organisation> partner = new List<Organisation>();
            partner.Add(new Organisation()
            {
                Organisation_Name = "XYZ",
                Organisation_Address = "ABC street",
                Organistion_Postcode = "232335",
                Recruitment_Address = "PQR street",
                Recruitment_Name = "James",
                Recruitment_Number = "34567"
            });

            partner.Add(new Organisation()
            {
                Organisation_Name = "ABC",
                Organisation_Address = "Abbot's Road",
                Organistion_Postcode = "2345",
                Recruitment_Address = "Abbotwell street",
                Recruitment_Name = "Alexander",
                Recruitment_Number = "34345567"
            });

            partner.Add(new Organisation()
            {
                Organisation_Name = "FGHI",
                Organisation_Address = "Abingdon street",
                Organistion_Postcode = "236745",
                Recruitment_Address = "Albert street",
                Recruitment_Name = "John",
                Recruitment_Number = "344456567"
            });

            Partner_data.ItemsSource = partner;

        }


        private void vacancy_data_load()
        {
            List<vacancy> vacancies = new List<vacancy>();
            vacancies.Add(new vacancy()
            {
                StartDate = "27-11-22",
                Salary = "11000",
                Max_Qualification = "12th passed",
                Experience = "3",
                DrivingLicense = true,
                Criminal_Conviction = false,
                Type_of_Work = "driving"

            });


            vacancies.Add(new vacancy()
            {
                StartDate = "28-11-22",
                Salary = "15000",
                Max_Qualification = "12th passed",
                Experience = "1",
                DrivingLicense = false,
                Criminal_Conviction = false,
                Type_of_Work = "gardening"
            });



            vacancy_data.ItemsSource = vacancies;


        }


        private void client_data_load()
        {
            List<Client> Clients = new List<Client>();
            Clients.Add(new Client()
            {
                Client_Name = "ABC",
                Client_Address = "XYZ street",
                Client_Email = "abc@gmail.com",
                Client_Phone = "12345678",
                DrivingLicense = true,
                Max_Distance = 20,
                Work = "driving"


            });

            Clients.Add(new Client()
            {
                Client_Name = "Jack",
                Client_Address = "Abbey street",
                Client_Email = "jack@gmail",
                Client_Phone = "1267948",
                DrivingLicense = true,
                Max_Distance = 25,

                Work = "gardening"

            });


            client_data.ItemsSource = Clients;

        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow login_page = new MainWindow();
            login_page.Show();

        }

        private void add_new_partner_Click(object sender, RoutedEventArgs e)
        {
            add_client.Visibility = Visibility.Hidden;
            ADD_VACANCY.Visibility = Visibility.Hidden;
            available_vacancy_detail_list.Visibility = Visibility.Hidden;
            client_detail_list.Visibility = Visibility.Hidden;
            pop_up_window.Visibility = Visibility.Hidden;
            partner_detail_list.Visibility = Visibility.Hidden;
            partner_registration.Visibility = Visibility.Visible;
        }

        private void add_new_client_Click(object sender, RoutedEventArgs e)
        {
            ADD_VACANCY.Visibility = Visibility.Hidden;
            partner_registration.Visibility = Visibility.Hidden;
            available_vacancy_detail_list.Visibility = Visibility.Hidden;
            client_detail_list.Visibility = Visibility.Hidden;
            pop_up_window.Visibility = Visibility.Hidden;
            partner_detail_list.Visibility = Visibility.Hidden;
            add_client.Visibility = Visibility.Visible;
        }

        private void add_new_vacancy_Click(object sender, RoutedEventArgs e)
        {
            add_client.Visibility = Visibility.Hidden;
            partner_registration.Visibility = Visibility.Hidden;
            available_vacancy_detail_list.Visibility = Visibility.Hidden;
            pop_up_window.Visibility = Visibility.Hidden;
            client_detail_list.Visibility = Visibility.Hidden;
            partner_detail_list.Visibility = Visibility.Hidden;
            ADD_VACANCY.Visibility = Visibility.Visible;
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            pop_up_window.Visibility = Visibility.Visible;
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {
            pop_up_window.Visibility = Visibility.Visible;
        }
    }
}
