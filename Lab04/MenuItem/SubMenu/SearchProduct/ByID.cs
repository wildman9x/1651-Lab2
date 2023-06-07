using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Lab04.Interface;
using Lab04.Singleton;

namespace Lab04.MenuItem.SubMenu.SearchProduct
{
    public class ByID : IMenuItem
    {
        public string Name => "Search by ID";
        public void Run() {
            Console.WriteLine("Enter product ID:");
            int id = int.Parse(Console.ReadLine());
            var product = ProductDict.Instance.Products.Where(p => p.Key == id);
            if (product.Count() == 0)
            {
                Console.WriteLine("No product found!");
            }
            else
            {
                Console.WriteLine("Product found:");
                var table = new ConsoleTable("ID", "Name", "Price");
                foreach (var p in product)
                {
                    table.AddRow(p.Key, p.Value.Name, p.Value.Price);
                }
                table.Write();
            }
        }
    }
}