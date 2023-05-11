using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.SearchProductsItems
{
    public class ByProductionDate : SearchProducts
    {
        public string GetName()
        {
            return "Search for a Product by production date";
        }

        public void Run()
        {
            Console.WriteLine("Enter the production date of the product you want to search for: ");
            string productionDate = Console.ReadLine();
            foreach (var product in Program.products.Values)
            {
                if (product.ManufactureDate.Equals(productionDate))
                {
                    product.PrintInfo();
                }
            }
        }
    }
}