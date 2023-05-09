using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;
using Lab01.Public;

namespace Lab01.MainMenuItems
{
    public class PerfectSquare : MainMenuItem
    {
        public string GetName()
        {
            return "Find out if a number is a perfect square";
        }

        public void Run()
        {
            Console.WriteLine("Please enter a number:");
            try
            {
                int number = int.Parse(Console.ReadLine());
                int squareRoot = (int)Math.Sqrt(number);
                if (squareRoot * squareRoot == number)
                {
                    Console.WriteLine("{0} is a perfect square", number);
                }
                else
                {
                    Console.WriteLine("{0} is not a perfect square", number);
                }
            }
            catch (FormatException)
            {
                InvalidOption.Print();
            }

        }
    }
}