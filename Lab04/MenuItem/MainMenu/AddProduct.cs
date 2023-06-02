using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;
using Lab04.Model;
using Lab04.Singleton;

namespace Lab04.MenuItem.MainMenu
{
    public class AddProduct : IMenuItem
    {
        public string Name => "Add Product";

        public void Run()
        {
            Console.WriteLine("Enter product name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            var price = double.Parse(Console.ReadLine());
            var product = new Product(name, price);
            ProductDict.Instance.Add(product);
            Console.WriteLine("Add product successfully!");
        }
    }
}