using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Windows.Controls;
using System;
using System.Windows;

namespace Sale_System
{
    internal partial class Bill_WindowVM : ObservableObject
    {

        [ObservableProperty]
        public int productId;

        [ObservableProperty]
        public int productQuantity;

        [ObservableProperty]
        public string productName;

        [ObservableProperty]
        public double productPrice;

        [ObservableProperty]
        public double discount;

        [ObservableProperty]
        public double totalProductPrice;

        [ObservableProperty]
        ObservableCollection<BillData> billData;

        [ObservableProperty]
        public StoreData product;

        [ObservableProperty]
        ObservableCollection<StoreData> stores;

        [ObservableProperty]
        public double total = 0;

        [RelayCommand]
        public void InsertData()
        {


            using (var db = new DataBaseContext())
            {
                var product = db.Store_Database.Where(r => r.ProductId == ProductId);
                if (product.Count() == 1)
                {


                    foreach (var r in product)
                    {
                        ProductId = r.ProductId;
                        ProductName = r.ProductName;
                        ProductPrice = r.ProductPrice;
                        ProductQuantity = ProductQuantity;
                        Discount = r.Discount;

                        Logic totalProductPrice = new Logic(ProductPrice, ProductQuantity, Discount);
                        TotalProductPrice = (int)totalProductPrice.CalctotalProductPrice();

                        Logic total = new Logic(Total, TotalProductPrice);
                        Total = total.Calctotal();
                    }


                    Debug.WriteLine("Name");
                    billData.Add(new BillData(ProductId, ProductName, ProductPrice, ProductQuantity, Discount, TotalProductPrice));
                    Debug.WriteLine(billData);
                }
                else
                {
                    MessageBox.Show("No product found! Check your product ID");
                }
            }


        }


        [RelayCommand]
        public void DeleteData(BillData s)
        {
            if (s != null)
            {
                Total = (int)(Total - s.TotalProductPrice);
                billData.Remove(s);

            }
        }

        public Bill_WindowVM()
        {
            billData = new ObservableCollection<BillData>();
            using (var db = new DataBaseContext())
            {
                var list = db.Store_Database
                .OrderBy(s => s.ProductId)
                .ToList();
                Stores = new ObservableCollection<StoreData>(list);
            }

        }
    }
}
