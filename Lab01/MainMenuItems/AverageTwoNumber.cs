using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.MainMenuItems
{
    public class AverageTwoNumber : MainMenuItem
    {
        public string GetName()
        {
            return "Average of Two Numbers";
        }

        public void Run()
        {
            Console.WriteLine("Please enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("The average of the two numbers is: {0}", (firstNumber + secondNumber) / 2);
        }
    }
}