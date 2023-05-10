using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.CalculationTwoNumMenuItems
{
    public class Sum : CalculationTwoNumMenuItem
    {
        public string GetName()
        {
            return "Sum";
        }

        public void Run()
        {
            // take double numbers
            Console.WriteLine("Enter two numbers:");
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            // sum two numbers
            Console.WriteLine("Sum of two numbers: {0}", firstNum + secondNum);
            return;
        }
    }
}