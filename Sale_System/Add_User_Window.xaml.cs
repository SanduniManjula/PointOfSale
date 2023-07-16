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
    /// <summary>
    /// Interaction logic for Add_User_Window.xaml
    /// </summary>
    public partial class Add_User_Window : Window
    {
        User p;
        public Add_User_Window()
        {
            InitializeComponent();
            btn_insert.Visibility=Visibility.Visible;
            btn_delete.Visibility=Visibility.Visible;
            btn_edit.Visibility=Visibility.Visible;
            btn_logout.Visibility=Visibility.Visible;
            btn_save.Visibility=Visibility.Hidden;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            User p = userGrid.SelectedItem as User;
            var vm = (User_WindowVM)DataContext;
            vm.DeleteUser(p);
            tb_CompanyId.Text = null;
            tb_FirstName.Text = null;
            tb_LastName.Text = null;
            tb_UserName.Text = null;
            tb_Password.Text = null;
            tb_rePassword.Text = null;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            
                btn_delete.Visibility = Visibility.Hidden;
                btn_edit.Visibility = Visibility.Hidden;
                btn_logout.Visibility = Visibility.Hidden;
                btn_insert.Visibility = Visibility.Hidden;

                p = userGrid.SelectedItem as User;

                tb_CompanyId.Text = Convert.ToString(p.CompanyId);
                tb_FirstName.Text = p.FirstName;
                tb_LastName.Text = p.LastName;
                tb_UserName.Text = p.UserName;
                tb_Password.Text = p.Password;
                tb_rePassword.Text = p.Password;

                btn_save.Visibility = Visibility.Visible;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var vm = (User_WindowVM)DataContext;
            vm.InsertUser();

            tb_CompanyId.Text = null;
            tb_FirstName.Text = null;
            tb_LastName.Text = null;
            tb_UserName.Text = null;
            tb_Password.Text = null;
            tb_rePassword.Text = null;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var vm = (User_WindowVM)DataContext;
            vm.EditUser(p);
            tb_CompanyId.Text = null;
            tb_FirstName.Text = null;
            tb_LastName.Text = null;
            tb_UserName.Text = null;
            tb_Password.Text = null;
            tb_rePassword.Text = null;

            btn_insert.Visibility = Visibility.Visible;
            btn_delete.Visibility = Visibility.Visible;
            btn_edit.Visibility = Visibility.Visible;
            btn_logout.Visibility = Visibility.Visible;
            btn_save.Visibility = Visibility.Hidden;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Window();
            window.Show();
            this.Close();
        }
    }
}
