using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sale_System
{
    public partial class StoreData_WindowVM : ObservableObject
    {

        [ObservableProperty]
        public int productId;

        [ObservableProperty]
        public string productName;

        [ObservableProperty]
        public int productPrice;

        [ObservableProperty]
        public int discount;
 

        [ObservableProperty]
        ObservableCollection<StoreData> stores;


        [RelayCommand]
        public void InsertData()
        {
            StoreData s = new StoreData()
            {
                ProductId = ProductId,
                ProductName = ProductName,
                ProductPrice = ProductPrice,
                Discount = Discount,
               

            };
            using (var db = new DataBaseContext())
            {
                db.Store_Database.Add(s);
                db.SaveChanges();
            }
            LoadData();

        }
   
        public void LoadData()
        {
            using (var db = new DataBaseContext())
            {
                var list = db.Store_Database
                .OrderBy(s => s.ProductId)
                .ToList();
                Stores = new ObservableCollection<StoreData>(list);
            }
        }

        [RelayCommand]
        public void DeleteData(StoreData s)
        {
            using (var db = new DataBaseContext())
            {
                var selectedData = db.Store_Database.Where(r => r.ProductId == s.ProductId);
                foreach (var stores in selectedData)
                {
                    db.Store_Database.Remove(stores);
                }
                db.SaveChanges();
            }
            LoadData();
        }


        public void EditData(StoreData s)
        {
            using (var db = new DataBaseContext())
            {
                if (ProductId != s.ProductId)
                {
                    DeleteData(s);
                    InsertData();
                    
                }
                else
                {
                    s.ProductId = ProductId;
                    s.ProductName = ProductName;
                    s.ProductPrice = ProductPrice;
                    s.Discount = Discount;
                   

                    db.Store_Database.Update(s);
                    db.SaveChanges();
                }


            }
            LoadData();
        }



        public StoreData_WindowVM()
        {
            LoadData();

        }
    }
}
    