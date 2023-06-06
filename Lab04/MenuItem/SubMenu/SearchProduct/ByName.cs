using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;
using Lab04.Singleton;

namespace Lab04.MenuItem.SubMenu.SearchProduct
{
    public class ByName : IMenuItem
    {
        public string Name => "Search by name";
        public void Run() {
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            var products = ProductDict.Instance.Products.Where(p => p.Value.Name.ToLower().Contains(name.ToLower()));
            if (products.Count() == 0)
            {
                Console.WriteLine("No product found!");
            }
            else
            {
                Console.WriteLine("Product found:");
                foreach (var product in products)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
}