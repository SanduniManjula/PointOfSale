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
    /// Interaction logic for Store_Database_Window.xaml
    /// </summary>
    public partial class Store_Database_Window : Window
    {
        StoreData s;
        public Store_Database_Window()
        {
            InitializeComponent();
            btn_Insert.Visibility = Visibility.Visible;
            btn_Delete.Visibility = Visibility.Visible;
            btn_Edit.Visibility = Visibility.Visible;
            btn_Logout.Visibility = Visibility.Visible;
            btn_Save.Visibility = Visibility.Hidden;
            btn_Return.Visibility = Visibility.Visible;

        }

        private void Logout_Click1(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var window = new Admin_Window();
            window.Show();
            this.Close();
        }

        private void Delete_Click1(object sender, RoutedEventArgs e)
        {
            StoreData s = Dataa.SelectedItem as StoreData;
            var vm = (StoreData_WindowVM)DataContext;
            vm.DeleteData(s);
            tb_ProductId.Text = null;
            tb_ProductName.Text = null;
            tb_ProductPrice.Text = null;
            tb_Discount.Text = null;

        }

        private void Edit_Click1(object sender, RoutedEventArgs e)
        {
            btn_Delete.Visibility = Visibility.Hidden;
            btn_Edit.Visibility = Visibility.Hidden;
            btn_Logout.Visibility = Visibility.Hidden;
            btn_Insert.Visibility = Visibility.Hidden;
            btn_Return.Visibility = Visibility.Visible;

            s = Dataa.SelectedItem as StoreData;

            tb_ProductId.Text = Convert.ToString(s.ProductId);
            tb_ProductName.Text = s.ProductName;
            tb_ProductPrice.Text = Convert.ToString(s.ProductPrice);
            tb_Discount.Text = Convert.ToString(s.Discount);


            btn_Save.Visibility = Visibility.Visible;

        }

        private void Insert_Click1(object sender, RoutedEventArgs e)
        {
            var vm = (StoreData_WindowVM)DataContext;
            vm.InsertData();

            tb_ProductId.Text = null;
            tb_ProductName.Text = null;
            tb_ProductPrice.Text = null;
            tb_Discount.Text = null;
        }

        private void Save_Click1(object sender, RoutedEventArgs e)
        {
            var vm = (StoreData_WindowVM)DataContext;
            vm.EditData(s);
            tb_ProductId.Text = null;
            tb_ProductName.Text = null;
            tb_ProductPrice.Text = null;
            tb_Discount.Text = null;

            btn_Insert.Visibility = Visibility.Visible;
            btn_Delete.Visibility = Visibility.Visible;
            btn_Edit.Visibility = Visibility.Visible;
            btn_Logout.Visibility = Visibility.Visible;
            btn_Save.Visibility = Visibility.Hidden;
            btn_Return.Visibility = Visibility.Visible;
        }
    }
}

