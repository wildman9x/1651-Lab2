using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Lab05.Interface;
using Lab05.Models;

namespace Lab05.Strategy.ProductStrategy
{
    public class BySize : ProductSearchStrategy
    {
        public void Search(Dictionary<int, Product> products)
        {
            Console.WriteLine("Search by size");
            Console.WriteLine("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            var table = new ConsoleTable("ID", "Name", "Price", "Size", "Quantity");
            foreach (var product in products.Values.Where(p => p.Size == size))
            {
                table.AddRow(product.ID, product.Name, product.Price, product.Size, product.Quantity);
            }
            table.Write();
        }
    }
}