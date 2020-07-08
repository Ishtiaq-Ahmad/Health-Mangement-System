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
    /// Interaction logic for NurseModule.xaml
    /// </summary>
    public partial class NurseModule : Window
    {
        public NurseModule()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "" && passwordBox.Password == "")
            {
                MessageBox.Show("Please Enter Username and Password");
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True");
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    string query = "SELECT COUNT(1) FROM NurseModuleTB WHERE Username=@Username AND Password=@Password";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    sqlcmd.Parameters.AddWithValue("@Password", passwordBox.Password);
                    int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    if (count == 1)
                    {
                        Patient_History his = new Patient_History();
                        his.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid");
                    }
                    textBoxUsername.Clear();
                    passwordBox.Clear();
                    textBoxUsername.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                }

            }
        }

        private void buttonexit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow dowe = new MainWindow();
            dowe.Show();
            this.Close();

        }
    }
}
