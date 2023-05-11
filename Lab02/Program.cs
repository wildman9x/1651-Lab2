using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;
using Lab02.Public;

namespace Lab02
{
    public class Program
    {
        public static Dictionary<string, Product> products = new Dictionary<string, Product>(StringComparer.OrdinalIgnoreCase);
        public static void Main(string[] args)
        {
            while (true)
            {
                MenuDict.PrepareMenu(MenuDict.GetMenu(typeof(MainMenuItem)));
                Console.Clear();
            }
            
        }

        private static void SearchProduct(Dictionary<string, Product> products)
        {
            Console.WriteLine("Search for a product by name: ");
            string name = Console.ReadLine();
            if (products.ContainsKey(name))
            {
                products[name].PrintInfo();
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private static void AddProduct(Dictionary<string, Product> products)
        {
            Console.WriteLine("Add a product: ");
            string name = Console.ReadLine();
            if (products.ContainsKey(name))
            {
                Console.WriteLine("Product already exists!");
            }
            else
            {
                Product product = new Product();
                product.Name = name;
                Console.WriteLine("Manufacture Date: ");
                product.ManufactureDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Expiry Date: ");
                product.ExpiryDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Price: ");
                product.Price = double.Parse(Console.ReadLine());
                products.Add(name, product);
            }
        }
    }
}