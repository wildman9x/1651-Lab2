using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;
using Lab01.MainMenuItems;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            PrintMainMenu();
            // clear the console
            Console.Clear();
        }
    }

    public static void PrintMainMenu() {
        var exampleDictionary = new Dictionary<int, Type>();
        var exampleInterfaceType = typeof(MainMenuItem);
        var exampleClasses = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => exampleInterfaceType.IsAssignableFrom(p) && p.IsClass);

        int key = 0;
        foreach (var exampleClass in exampleClasses)
        {
            exampleDictionary.Add(key, exampleClass);
            key++;
        }

        Console.WriteLine("Welcome to the Main Menu!");
        Console.WriteLine("Please select an option:");
        foreach (var example in exampleDictionary)
        {
            // Write key and call the GetName() method on the class
            Console.WriteLine("{0}. {1}", example.Key, ((MainMenuItem)Activator.CreateInstance(example.Value)).GetName());
        }
        int option = int.Parse(Console.ReadLine());
        var exampleInstance = (MainMenuItem)Activator.CreateInstance(exampleDictionary[option]);
        exampleInstance.Run();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}