using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.Public.MainMenu
{
    public class Option
    {
        public static void Choose(Dictionary<int, Type> exampleDictionary)
        {
            try
            {
                int option = int.Parse(Console.ReadLine());
                // if the option is not in the dictionary, return
                if (!exampleDictionary.ContainsKey(option))
                {
                    InvalidOption.Print();
                    return;
                }
                var exampleInstance = (MainMenuItem)Activator.CreateInstance(exampleDictionary[option]);
                exampleInstance.Run();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                InvalidOption.Print();
                return;
            }
        }
    }
}