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
    /// Interaction logic for Patient_Surgery_List.xaml
    /// </summary>
    public partial class Patient_Surgery_List : Window
    {
        public Patient_Surgery_List()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataTable dt;
        
        private void textBoxEmployeeSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Name LIKE '%{0}%'", textBoxEmployeeSearch.Text);
            dataGridSurgicalPatientList.ItemsSource = DV;
           
        }

        private void buttonSurgeryList_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring;
            SqlConnection con;
            connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
            con = new SqlConnection(connectionstring);
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_PatientTB inner join SurgecalPatientTB3 on Add_PatientTB.PatientID = SurgecalPatientTB3.OperationNo ";
            da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            dt = new DataTable();
            da.Fill(dt);
            dataGridSurgicalPatientList.ItemsSource = dt.DefaultView;

        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            Patient_History en = new Patient_History();
            en.Show();
            this.Close();
        }
    }
}
