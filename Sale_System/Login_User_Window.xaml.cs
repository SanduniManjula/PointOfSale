using System.Linq;
using System.Windows;

namespace Sale_System
{
    /// <summary>
    /// Interaction logic for Login_User_Window.xaml
    /// </summary>
    public partial class Login_User_Window : Window
    {
        public Login_User_Window()
        {
            DataContext = new User_WindowVM();
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            using (var db = new DataBaseContext())
            {
                var user = db.User_Database.Where(r => r.UserName == username.Text && r.Password == password.Password.ToString());
                if (user.Count() == 1)
                {
                    var window = new Bill_Window();
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
