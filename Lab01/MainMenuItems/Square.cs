using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.MainMenuItems
{
    public class Square : MainMenuItem
    {
        public string GetName()
        {
            return "Square a number";
        }

        public void Run()
        {
            Console.WriteLine("Enter a number to square:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} squared is {1}", n, n * n);
        }
    }
}