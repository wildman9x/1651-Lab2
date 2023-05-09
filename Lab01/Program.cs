using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;
using Lab01.MainMenuItems;
using Lab01.Public;

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
        // Create a dictionary of the MainMenuItem interface
        Dictionary<int, Type> exampleDictionary = MainMenuDict.GetDict();

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