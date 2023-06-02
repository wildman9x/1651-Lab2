using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Interface;
using Lab04.MenuItem;

namespace Lab04;
class Program
{
    static void Main(string[] args)
    {
        var Context = new Context();
        Dictionary<int, IMenuItem> menuItems = new Dictionary<int, IMenuItem>();
        menuItems.Add(menuItems.Count, new MenuItem.MainMenu.Exit());
        menuItems.Add(menuItems.Count, new MenuItem.MainMenu.ShowAllProduct());
        menuItems.Add(menuItems.Count, new MenuItem.MainMenu.AddProduct());

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine($"{menuItem.Key}. {menuItem.Value.Name}");
            }
            Console.WriteLine("Enter your choice:");
            try
            {
                var choice = int.Parse(Console.ReadLine());
                if (menuItems.ContainsKey(choice))
                {
                    Context.SetStrategy(menuItems[choice]);
                    Context.RunStrategy();
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid choice!");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
