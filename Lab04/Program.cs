using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lab04.Interface;
using Lab04.MenuItem;

namespace Lab04;
class Program
{
    static void Main(string[] args)
    {
        var Context = new Context();
        // Create all class in the MenuItem.MainMenu namespace and put into the menuItems dictionary
        List<IMenuItem> menuItemsList = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.Namespace == "Lab04.MenuItem.MainMenu" && t.IsClass && !t.IsAbstract && typeof(IMenuItem).IsAssignableFrom(t))
            .Select(t => Activator.CreateInstance(t) as IMenuItem).ToList();
        Dictionary<int, IMenuItem> menuItems = new();
        foreach (var menuItem in menuItemsList)
        {
            menuItems.Add(menuItems.Count, menuItem);
        }
        
        // menuItems.Add(menuItems.Count, new MenuItem.MainMenu.Exit());
        // menuItems.Add(menuItems.Count, new MenuItem.MainMenu.ShowAllProduct());
        // menuItems.Add(menuItems.Count, new MenuItem.MainMenu.AddProduct());
        

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
                
                    Context.SetStrategy(menuItems[choice]);
                    Context.RunStrategy();
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
