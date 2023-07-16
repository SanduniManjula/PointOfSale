using System.Windows;

namespace Sale_System
{

    public partial class Bill_Window : Window
    {
        public Bill_Window()
        {
            InitializeComponent();
            DataContext = new Bill_WindowVM();
        }

        private void btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            var vm = (Bill_WindowVM)DataContext;
            vm.InsertData();
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            BillData s = bill.SelectedItem as BillData;
            var vm = (Bill_WindowVM)DataContext;
            vm.DeleteData(s);
            tb_ProductId.Text = null;
            tb_ProductName.Text = null;
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }
        //private void btn_Return_Click(object sender, RoutedEventArgs e)
        //{
        //    var window = new MainWindow();
        //    window.Show();
        //    this.Close();
        //}

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            var window = new Bill_Window();
            window.Show();
            this.Close();
        }
    }
}
