using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sale_System
{
    public class BillData
    {
        public BillData(int productId, string productName, double productPrice, int productQuantity, double discount, double totalProductPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            Discount = discount;
            TotalProductPrice = totalProductPrice;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public double Discount { get; set; }
        public double TotalProductPrice { get; set; }
    }
}