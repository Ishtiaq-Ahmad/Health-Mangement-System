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
    /// Interaction logic for Surgery.xaml
    /// </summary>
    public partial class Surgery : Window
    {
        public Surgery()
        {
            InitializeComponent();
        }
        SqlCommandBuilder cmdl;
        SqlDataAdapter da;
        DataTable dt;
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxPid.Text != "")
            {
                int pid = Convert.ToInt32(textBoxPid.Text);
                string connectionstring;
                SqlConnection con;
                connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
                con = new SqlConnection(connectionstring);
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Add_PatientTB where PatientID = " + pid + "";
               da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                dt = new DataTable();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;



            }
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //int pid = Convert.ToInt32(textBoxPid.Text);
                int OperationNo = Convert.ToInt32(textBoxOperationNO.Text);
                string surgent = comboxSurgical.Text;
                string OperationRoom = comboxOperationRoom.Text;
                string OperationType = comboOperation.Text;
              

                string connectionstring;
                SqlConnection con;
                connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
                con = new SqlConnection(connectionstring);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into SurgecalPatientTB3 values (" + OperationNo+",'" + surgent + "','" + OperationRoom + "','" + OperationType + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet set = new DataSet();
                adapter.Fill(set);
            }
            catch
            {
                MessageBox.Show("textbox field is empty or 'OR' data is wrong");
            }
            MessageBox.Show("Data Saved");
            textBoxPid.Clear();
            textBoxOperationNO.Clear();
            comboxSurgical.SelectedItem = null;
            comboxOperationRoom.SelectedItem = null;
            comboOperation.SelectedItem = null;


        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cmdl = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information Updated", "Update");
            }
            catch
            {
                MessageBox.Show("Something error");
            }
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            Patient_History ti = new Patient_History();
            ti.Show();
            this.Close();
        }
    }
    
}
