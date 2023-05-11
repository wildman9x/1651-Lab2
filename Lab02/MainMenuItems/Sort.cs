using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.MainMenuItems
{
    public class Sort : MainMenuItem
    {
        public string GetName()
        {
            return "Sort";
        }

        public void Run()
        {
            Console.WriteLine("Sort by: ");
        }
    }
}