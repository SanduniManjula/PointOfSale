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

namespace Sale_System
{

    public partial class Admin_Window : Window
    {
        public Admin_Window()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var window = new Add_User_Window();
            window.Show();
            this.Close();
        }
        private void Store_Click(object sender, RoutedEventArgs e)
        {
            var window = new Store_Database_Window();
            window.Show();
            this.Close();
        }
    }
}
