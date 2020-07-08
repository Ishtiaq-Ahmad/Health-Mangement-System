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

namespace HealthManagementSystem
{
    /// <summary>
    /// Interaction logic for Add_Doctor.xaml
    /// </summary>
    public partial class Add_Doctor : Window
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            AdminManage am = new AdminManage();
            am.Show();
            this.Close();
        }

        private void buttonSace_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmpID.Text == "" && textBoxName.Text == "" && textBoxAge.Text == "" && textBoxEmail.Text == "" && textBoxPhoneNumber.Text == "" && textBoxAddress.Text == "")
            {
                MessageBox.Show("Please Enter Data");
            }
            else
            { 

             int empId = Convert.ToInt32(textBoxEmpID.Text);
            string name = textBoxName.Text;
            string gender = comboBoxGender.Text;
            int age = Convert.ToInt32(textBoxAge.Text);
            string email = textBoxEmail.Text;
            Int64 phoneNo = Convert.ToInt64(textBoxPhoneNumber.Text);
            string address = textBoxAddress.Text;
            string jobTitle = comboBoxJobtitle.Text;

                try
                {
                    string connectionstring;
                    SqlConnection con;
                    connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
                    con = new SqlConnection(connectionstring);
                    con.Open();

                    SqlCommand cmd;
                    SqlDataAdapter da = new SqlDataAdapter();
                    string sql = "insert into Add_employeeTB values (" + empId + ",'" + name + "','" + gender + "', " + age + ",'" + email + "'," + phoneNo + ",'" + address + "','" + jobTitle + "')";
                    cmd = new SqlCommand(sql, con);
                    da.InsertCommand = new SqlCommand(sql, con);
                    da.InsertCommand.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("incorrect data");
                }
                MessageBox.Show("Data saved");
                textBoxEmpID.Clear();
                textBoxName.Clear();
                textBoxAddress.Clear();
                textBoxAge.Clear();
                textBoxPhoneNumber.Clear();
                textBoxAge.Clear();
                textBoxEmail.Clear();
                comboBoxGender.SelectedItem = null;
                comboBoxJobtitle.SelectedItem = null;



            }
        }
       
    }
    
}
