using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Lab05.Interface;
using Lab05.Models;
using Lab05.Singleton;

namespace Lab05.Strategy.ProductStrategy
{
    public class ByName : ProductSearchStrategy
    {
        public void Search(Dictionary<int, Product> products) {
            Console.WriteLine("Search by name");
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            var table = new ConsoleTable("ID", "Name", "Price", "Quantity");
            foreach (var product in products.Values)
            {
                if (product.Name.Contains(name))
                {
                    table.AddRow(product.ID, product.Name, product.Price, product.Quantity);
                }
            }
            table.Write();
        }
    }
}