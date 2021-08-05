using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsGenericLib
{
    public class Product
    {
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public double Total
        {
            get { return UnitPrice * Qty; }
        }

        public Product(string _productName, double _unitPrice, int _qty)
        {
            ProductName = _productName;
            UnitPrice = _unitPrice;
            Qty = _qty;
        }

        public override string ToString()
        {
            return string.Format($"Product Name: {ProductName} | Unit Price: {UnitPrice} | Quantity: {Qty} | Total: {Total}");
        }
    }
}
