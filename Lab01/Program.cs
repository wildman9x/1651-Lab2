using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;
using Lab01.MainMenuItems;
using Lab01.Public;
using Lab01.Public.MainMenu;

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
        Dictionary<int, Type> exampleDictionary = MainMenuDict.GetDict();

        MainMenuPrint.PrintMainMenu();
        Option.Choose(exampleDictionary);

    }
}