using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.CalculationTwoNumMenuItems
{
    public class Division : CalculationTwoNumMenuItem
    {
        public string GetName()
        {
            return "Divide two numbers";
        }

        public void Run()
        {
            // take double numbers
            Console.WriteLine("Enter two numbers:");
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            // check if second number is zero
            if (secondNum == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            // divide two numbers
            Console.WriteLine("Division of two numbers: {0}", firstNum / secondNum);
            return;
        }
    }
}