using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.Public.MainMenu
{
    public class MainMenuPrint
    {
        public static void PrintMainMenu()
        {
            // Create a dictionary of the MainMenuItem interface
            Dictionary<int, Type> exampleDictionary = MainMenuDict.GetDict();

            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("Please select an option:");
            foreach (var example in exampleDictionary)
            {
                // Write key and call the GetName() method on the class
                Console.WriteLine("{0}. {1}", example.Key, ((MainMenuItem)Activator.CreateInstance(example.Value)).GetName());
            }
        }
    }
}