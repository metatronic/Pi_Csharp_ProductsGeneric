using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsGenericLib;

namespace ProductCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice, reRun = "N";
            ProductCollection productCollection = new ProductCollection();
            do
            {
                Console.WriteLine("1 Add \n2 Delete \n3 Display \n4 Search \n5 Query \n6 Quit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        string productName;
                        double unitPrice;
                        int quanity;
                        Console.WriteLine("Enter Product Name:");
                        productName = Console.ReadLine();
                        Console.WriteLine("Enter Unit Price:");
                        unitPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Product Quantity:");
                        quanity = Convert.ToInt32(Console.ReadLine());
                        productCollection.AddProduct(new Product(productName, unitPrice, quanity));
                        break;
                    case "2":
                        string productToDelete;
                        Console.WriteLine("Enter name of product to be deleted:");
                        productToDelete = Console.ReadLine();
                        productCollection.DeleteProduct(productToDelete);
                        break;
                    case "3":
                        productCollection.DisplayAll();
                        break;
                    case "4":
                        string productToSearch;
                        Console.WriteLine("Enter name of product to be searched:");
                        productToSearch = Console.ReadLine();
                        Product searchedProduct = productCollection.Search(productToSearch);
                        if (searchedProduct != null)
                        {
                            Console.WriteLine(searchedProduct.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Product not found");
                        }
                        break;
                    case "5":
                        double queryAmount;
                        Console.WriteLine("Enter Query Price");
                        queryAmount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter comparator ( < , > , = )");
                        string selectedOperator = Console.ReadLine();
                        Product[] productsArray;
                        switch (selectedOperator)
                        {
                            case "<":
                                productsArray = productCollection.QueryUnitPrice('<', queryAmount);
                                break;
                            case ">":
                                productsArray = productCollection.QueryUnitPrice('>', queryAmount);
                                break;
                            case "=":
                                productsArray = productCollection.QueryUnitPrice('=', queryAmount);
                                break;
                            default: Console.WriteLine("Please enter Proper operator");
                                continue;
                        }
                        foreach(Product queryProduct in productsArray)
                        {
                            Console.WriteLine(queryProduct.ToString());
                        }
                        break;
                    case "6": return;
                }
                Console.WriteLine("Continue ? (y/n)");
                reRun = Console.ReadLine();
            } while (reRun == "y");
        }
    }
}
