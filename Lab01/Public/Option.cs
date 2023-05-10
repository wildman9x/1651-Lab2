using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.Public
{
    public class Option
    {
        public static void Choose(Dictionary<int, Type> exampleDictionary, bool pressKey = true)
        {
            try
            {
                int option = int.Parse(Console.ReadLine());
                var exampleInstance = (MenuItem)Activator.CreateInstance(exampleDictionary[option]);
                exampleInstance.Run();
                if (pressKey){
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                InvalidOption.Print(pressKey);
                return;
            }
        }
    }
}