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
    /// Interaction logic for Employee_List.xaml
    /// </summary>
    public partial class Employee_List : Window
    {
        public Employee_List()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlCommandBuilder cmdl;
        SqlDataAdapter da;
        private void buttonShowAllEmployee_Click(object sender, RoutedEventArgs e)
        {

            string connectionstring;
            SqlConnection con;
            connectionstring = @"Data Source=DESKTOP-BEVBO3D\SQLSERVER;Initial Catalog=Health_DB;Integrated Security=True";
            con = new SqlConnection(connectionstring);
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_employeeTB";
            da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            dt = new DataTable();
            da.Fill(dt);
            dataGridEmployeeList.ItemsSource = dt.DefaultView;

            //dataGrid.ItemsSource = dt.DefaultView;
        }

        private void textSearch(object sender, TextChangedEventArgs e)
        {

            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Name LIKE '%{0}%'", textBoxEmployeeSearch.Text);
            dataGridEmployeeList.ItemsSource = DV;
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
            AdminManage man = new AdminManage();
            man.Show();
            this.Close();

        }


        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {

            var selectedItem = dataGridEmployeeList.SelectedItem;
            if (selectedItem != null)
            {
              dataGridEmployeeList.Items.Remove(selectedItem);
                MessageBox.Show("Data has been removed");
            }
            
        }

    
    }
    }
