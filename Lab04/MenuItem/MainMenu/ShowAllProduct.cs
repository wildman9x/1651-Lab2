using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;
using Lab04.Model;
using Lab04.Singleton;

namespace Lab04.MenuItem.MainMenu
{
    public class ShowAllProduct : IMenuItem
    {
        public string Name => "Show All Product";

        public void Run()
        {
            Console.WriteLine("List of products:");
            foreach (var product in ProductDict.Instance.Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}