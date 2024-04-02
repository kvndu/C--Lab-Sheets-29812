using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            ProductName = name;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Smartphone", 499.99);

            Console.WriteLine("Product 1:");
            Console.WriteLine($"Name: {product1.ProductName}");
            Console.WriteLine($"Price: ${product1.Price}");

            Console.WriteLine("\nProduct 2:");
            Console.WriteLine($"Name: {product2.ProductName}");
            Console.WriteLine($"Price: ${product2.Price}");

            Console.ReadLine();
        }
    }
}
