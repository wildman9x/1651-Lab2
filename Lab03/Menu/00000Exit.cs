using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;

namespace Lab01.MainMenuItems
{
    public class Exit : MainMenuItem
    {
        public string GetName()
        {
            return "Exit";
        }

        public void Run()
        {
            Console.WriteLine("Goodbye!");
            System.Environment.Exit(0);
        }
    }
}