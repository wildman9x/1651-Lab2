using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Lab05.Interface;
using Lab05.Models;

namespace Lab05.Strategy.ProductStrategy
{
    public class ByID : ProductSearchStrategy
    {
        public void Search(Dictionary<int, Product> products)
        {
            Console.WriteLine("Search by ID");
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                var table = new ConsoleTable("ID", "Name", "Price", "Quantity");
                var product = products[id];
                table.AddRow(product.ID, product.Name, product.Price, product.Quantity);
                table.Write();
            }
            catch (Exception)
            {
                Console.WriteLine("ID not found");
            }
        }
    }
}