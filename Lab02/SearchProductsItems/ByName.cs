using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.SearchProductsItems
{
    public class ByName : SearchProducts
    {
        public string GetName()
        {
            return "Search for a Product by name";
        }

        public void Run()
        {
            Console.WriteLine("Enter the name of the product you want to search for: ");
            string name = Console.ReadLine();
            if (Program.products.ContainsKey(name))
            {
                Program.products[name].PrintInfo();
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}