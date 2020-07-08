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
    /// Interaction logic for Add_Patient.xaml
    /// </summary>
    public partial class Add_Patient : Window
    {
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            Patient_History ph = new Patient_History();
            ph.Show();
            this.Close();

        }

        private void buttonSace_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxPatiedId.Text == "" && textBoxName.Text == "" && textBoxAge.Text == "" && textBoxContact.Text == "" && textBoxMjorDisease.Text == "" && textBoxAddress.Text == "" )
            {
                MessageBox.Show("Please Enter Data");
            }
            else
            {

                int PatientId = Convert.ToInt32(textBoxPatiedId.Text);
                string name = textBoxName.Text;
                string gender = comboGender.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                string bloodgroup = comboBoxBloodGroup.Text;
                Int64 contact = Convert.ToInt64(textBoxContact.Text);
                string address = textBoxAddress.Text;
                string disease = textBoxMjorDisease.Text;
                // var date = DatePicker.SelectedDate.ToString();

                try
                {
                    string connectionstring;
                    SqlConnection con;
                    connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
                    con = new SqlConnection(connectionstring);
                    con.Open();

                    SqlCommand cmd;
                    SqlDataAdapter da = new SqlDataAdapter();
                    string sql = "INSERT INTO Add_PatientTB VALUES(" + PatientId + ",'" + name + "', " + age + ", " + contact + ",'" + address + "','" + gender + "', '" + bloodgroup + "','" + disease + "' )";
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
                textBoxPatiedId.Clear();
                textBoxName.Clear();
                textBoxAddress.Clear();
                textBoxAge.Clear();
                textBoxContact.Clear();
                textBoxAge.Clear();
                textBoxMjorDisease.Clear();
                comboBoxBloodGroup.SelectedItem = null;
                comboGender.SelectedItem = null;



            }
        }
    }
    
}
