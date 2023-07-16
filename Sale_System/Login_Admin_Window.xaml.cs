using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sale_System
{
    /// <summary>
    /// Interaction logic for Login_Admin_Window.xaml
    /// </summary>
    public partial class Login_Admin_Window : Window
    {
        public Login_Admin_Window()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //var window = new Admin_Window();
            //window.Show();
            //this.Close();
            using (var db = new DataBaseContext())
            {
                var adminUser = db.Admin_Database.Where(r => r.UserName == username.Text && r.Password == password.Password.ToString());
                if (adminUser.Count() == 1)
                {
                    var window = new Admin_Window();
                    window.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }

        }


    }
}
