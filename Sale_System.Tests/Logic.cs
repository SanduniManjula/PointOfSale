using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_System.Tests
{
    public class Logic
    {

        public double Total { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public double Discount { get; set; }
        public double TotalProductPrice { get; set; }

        public Logic(double total, double totalProductPrice)
        {
            Total = total;
            TotalProductPrice = totalProductPrice;
        }

        public Logic(double productPrice, int productQuantity, double discount)
        {
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            Discount = discount;
        }

        public double CalctotalProductPrice()  //must have to override abstact methord in parent class
        {
            return (ProductPrice * ProductQuantity * (100 - Discount) / 100);
        }

        public double Calctotal()  //must have to override abstact methord in parent class
        {
            Debug.WriteLine(Total);
            Debug.WriteLine(TotalProductPrice);
            return Total + TotalProductPrice;
        }
    }



}

