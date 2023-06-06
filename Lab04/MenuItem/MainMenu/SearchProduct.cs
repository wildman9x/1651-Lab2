using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lab04.Interface;
using Lab04.Singleton;

namespace Lab04.MenuItem.MainMenu
{
    public class SearchProduct : IMenuItem
    {
        public string Name => "Search product";
        public void Run() {
            // Create all class in the MenuItem.MainMenu namespace and put into the menuItems dictionary
            List<IMenuItem> menuItemsList = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "Lab04.MenuItem.SubMenu.SearchProduct" && t.IsClass && !t.IsAbstract && typeof(IMenuItem).IsAssignableFrom(t))
                .Select(t => Activator.CreateInstance(t) as IMenuItem).ToList();
            Dictionary<int, IMenuItem> menuItems = new();
            menuItems.Add(menuItems.Count, new MenuItem.SubMenu.Back());
            foreach (var menuItem in menuItemsList)
            {
                menuItems.Add(menuItems.Count, menuItem);
            }
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
                    
                        Singleton.Context.Instance.SetStrategy(menuItems[choice]);
                        Singleton.Context.Instance.RunStrategy();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid choice!");
                }
                // Console.WriteLine("Press any key to continue...");
                // Console.ReadKey();
            
        }
    }
}