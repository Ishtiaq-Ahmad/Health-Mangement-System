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
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Window
    {
        public Prescription()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        
        private void textBoxPatiedId_TextChanged(object sender, TextChangedEventArgs e)
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
                IDataReader dr;
                //cmd.CommandText = "select * from Add_PatientTB inner join PatientDetailTB on Add_PatientTB.PatientID = PatientDetailTB.Symptoms ";
               cmd.CommandText = "select * from Add_PatientTB where PatientID = " + pid + "";
                dr = cmd.ExecuteReader();
                //da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                //dt = new DataTable();
                //da.Fill(ds);
                //textBoxName. = "Name";
                //dataGrid.ItemsSource = dt.DefaultView;
                if(dr.Read())
                {
                    textBoxName.Text = dr["Name"].ToString();
                    textBoxAge.Text = dr["Age"].ToString();
                    textBoxContact.Text = dr["Contact"].ToString();
                    textBoxMjorDisease.Text = dr["MajorDisease"].ToString();
                    textBoxaddress.Text = dr["Address"].ToString();
                    //textBoxSymptoms.Text = dr["Symptoms"].ToString();
                    //textBoxDiagnose.Text = dr["Diagnose"].ToString();
                   
                }
                else
                {
                    MessageBox.Show("Member Id not found");
                }



            }
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            PatientDetail dt = new PatientDetail();
            dt.Show();
            this.Close();
        }
    }
}
