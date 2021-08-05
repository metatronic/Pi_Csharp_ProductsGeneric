using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsGenericLib
{
    public class ProductCollection
    {
        private List<Product> productList;
        public ProductCollection()
        {
            productList = new List<Product>();
        }

        public void AddProduct(Product _product)
        {
            productList.Add(_product);
        }

        public void DeleteProduct(string _productName)
        {
            Product product;            
            if(productList.Exists(x => x.ProductName == _productName))
            {
                product = productList.Find(x => x.ProductName == _productName);
                productList.Remove(product);
            }
        }

        public void DisplayAll()
        {
            foreach(Product product in productList)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public Product Search(string _productName)
        {            
            if ( productList.Exists(x => x.ProductName == _productName))
            {
                return productList.Find(x => x.ProductName == _productName);
            }
            else
            {
                return null;
            }
        }


        public Product[] QueryUnitPrice(char _comparator, double _unitPrice)
        {
            List<Product> productQueryResult;
            switch (_comparator)
            {
                case '>':
                    productQueryResult = productList.FindAll(x => x.UnitPrice > _unitPrice);
                    return productQueryResult.ToArray();
                case '<':
                    productQueryResult = productList.FindAll(x => x.UnitPrice < _unitPrice);
                    return productQueryResult.ToArray();
                case '=':
                    productQueryResult = productList.FindAll(x => x.UnitPrice == _unitPrice);
                    return productQueryResult.ToArray();
                default:
                    throw new InvalidOperatorException("operator is not < , > , or =");

            }
        }
    }
}
