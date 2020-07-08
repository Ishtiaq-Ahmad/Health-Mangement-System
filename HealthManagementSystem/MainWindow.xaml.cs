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

namespace HealthManagementSystem
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin1 login = new AdminLogin1();
            login.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AdminManage manga = new AdminManage();
            manga.Show();
            this.Close();

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Add_Patient patient = new Add_Patient();
            patient.Show();
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Manage_Patientxaml patient = new Manage_Patientxaml();
            patient.Show();
            this.Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Patient_History history = new Patient_History();
            history.Show();
            this.Close();

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Surgery surgery = new Surgery();
            surgery.Show();
            this.Close();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Patient_Surgery_List list = new Patient_Surgery_List();
            list.Show();
            this.Close();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            PatientDetail detail = new PatientDetail();
            detail.Show();
            this.Close();
        }

        private void buttonDoctor_Click(object sender, RoutedEventArgs e)
        {
            DoctorLogin doctor = new DoctorLogin();
            doctor.Show();
            this.Close();
        }

        private void buttonNurse_Click(object sender, RoutedEventArgs e)
        {
            NurseModule nm = new NurseModule();
            nm.Show();
            this.Close();
        }

        private void buttonAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin1 log = new AdminLogin1();
            log.Show();
            this.Close();
        }

        private void buttonContactUs_Click(object sender, RoutedEventArgs e)
        {
            Contact_Us us = new Contact_Us();
            us.Show();
            this.Close();
        }

        private void buttonAboutUS_Click(object sender, RoutedEventArgs e)
        {
            aboutus about = new aboutus();
            about.Show();
            this.Close();
        }
    }
}
