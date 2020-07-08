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
    /// Interaction logic for Patient_History.xaml
    /// </summary>
    public partial class Patient_History : Window
    {
        public Patient_History()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder CB;
        private void buttonShowAllEmployee_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring;
            SqlConnection con;
            connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
            con = new SqlConnection(connectionstring);
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_PatientTB inner join PatentMoreTB on Add_PatientTB.PatientID = PatentMoreTB.PatientID ";
             da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            dt = new DataTable();
            da.Fill(dt);
            dataGridPatientList.ItemsSource = dt.DefaultView;
            
            //dataGrid.ItemsSource = dt.DefaultView;

        }

        private void textChangedSearch(object sender, TextChangedEventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Name LIKE '%{0}%'", textBoxEmployeeSearch.Text);
            dataGridPatientList.ItemsSource = DV;
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                
                //CB = new SqlCommandBuilder(da);
                //da.Update(dt);
                //MessageBox.Show("Information Updated", "Update");
            //}
            //catch
            //{
            //    MessageBox.Show("Something error");
            //}
        }

        private void buttonSurgicalPatientList_Click(object sender, RoutedEventArgs e)
        {
            Patient_Surgery_List surgery = new Patient_Surgery_List();
            surgery.Show();
            this.Close();
        }

        private void buttonSurgicalPatient_Click(object sender, RoutedEventArgs e)
        {
            Surgery surg = new Surgery();
            surg.Show();
            this.Close();
        }

        private void buttonManagepatient_Click(object sender, RoutedEventArgs e)
        {
            Manage_Patientxaml xaml = new Manage_Patientxaml();
            xaml.Show();
            this.Close();
        }

        private void buttonAddPatient_Click(object sender, RoutedEventArgs e)
        {
            Add_Patient ap = new Add_Patient();
           ap.Show();
            this.Close();
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            NurseModule mo = new NurseModule();
            mo.Show();
            this.Close();
        }
    }
}
