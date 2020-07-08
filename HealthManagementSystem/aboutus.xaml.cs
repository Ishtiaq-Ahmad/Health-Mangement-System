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

namespace HealthManagementSystem
{
    /// <summary>
    /// Interaction logic for aboutus.xaml
    /// </summary>
    public partial class aboutus : Window
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
