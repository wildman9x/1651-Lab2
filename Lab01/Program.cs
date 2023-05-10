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
            MainMenu();
            // clear the console
            Console.Clear();
        }
    }

    public static void MainMenu()
    {
        // Create a dictionary of the MainMenuItem interface
        Dictionary<int, Type> exampleDictionary = MenuDict.GetMenu(typeof(MainMenuItem));
        PrintMenu.Run(exampleDictionary);
        Option.Choose(exampleDictionary);
    }
}