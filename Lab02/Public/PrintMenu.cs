using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.Public
{
    public class PrintMenu
    {
        public static void Run(Dictionary<int, Type> dict) {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("Please select an option:");
            foreach (var example in dict)
            {
                // Write key and call the GetName() method on the class
                Console.WriteLine("{0}. {1}", example.Key, ((MenuItem)Activator.CreateInstance(example.Value)).GetName());
            }
        }
    }
}