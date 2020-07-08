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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace HealthManagementSystem
{
    /// <summary>
    /// Interaction logic for AdminManage.xaml
    /// </summary>
    public partial class AdminManage : Window
    {
        public AdminManage()
        {
            InitializeComponent();
        }

        private void buttonAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            Add_Doctor employee = new Add_Doctor();
            employee.Show();
            this.Close();

        }

        private void buttonEmployeList_Click(object sender, RoutedEventArgs e)
        {
            Employee_List list = new Employee_List();
            list.Show();
            this.Close();

        }

        private void buttonPatientList_Click(object sender, RoutedEventArgs e)
        {
            Patient_History hist = new Patient_History();
            hist.Show();
            this.Close();
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin1 lodinn = new AdminLogin1();
            lodinn.Show();
            this.Show();
        }

        private void buttonSurgicalPatientLsit_Click(object sender, RoutedEventArgs e)
        {
            Patient_Surgery_List surgent = new Patient_Surgery_List();
            surgent.Show();
            this.Close();

        }
    }
}
