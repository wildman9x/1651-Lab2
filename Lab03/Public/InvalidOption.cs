using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03.Public
{
    public class InvalidOption
    {
        public static void Print(bool pressKey = true)
        {
            if (pressKey)
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
        }
    }
}