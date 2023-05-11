using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.SearchProductsItems
{
    public class ByPrice : SearchProducts
    {
        public string GetName()
        {
            return "Search for a Product by price";
        }

        public void Run()
        {
            Console.WriteLine("Enter the price of the product you want to search for: ");
            string price = Console.ReadLine();
            foreach (var product in Program.products.Values)
            {
                if (product.Price.Equals(price))
                {
                    product.PrintInfo();
                }
            }
        }
    }
}