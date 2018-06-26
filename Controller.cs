using System;
using System.Collections.Generic;

namespace Test_AP
{
    public class Controller
    {
        List<Product> list = new List<Product>();

        public bool AddProduct()
        {
            Console.WriteLine("Please enter productId");
            string productId = Console.ReadLine();
            Console.WriteLine("Please enter productName");
            string productName = Console.ReadLine();
            Console.WriteLine("Please enter price");
            decimal price = decimal.Parse(Console.ReadLine());
            Product product = new Product(productId, productName, price);
            list.Add(product);
            return true;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Product Id", "Product Name", "Price");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (var product in list)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-20}", product.ProductId, product.ProductName, product.Price);
            }
        }

        public void DeleteProdcutById()
        {
            Console.WriteLine("delete product.");
            string id = Console.ReadLine();
            Product idDelete = list.Find(a => a.ProductId == id);
            list.Remove(idDelete);
        }
    }
}