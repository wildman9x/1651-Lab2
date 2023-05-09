using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.MainMenuItems
{
    public class Fibonacci : MainMenuItem
    {
        public string GetName()
        {
            return "Fibonacci";
        }

        public void Run()
        {
            Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine("The first {0} Fibonacci numbers are:", n);
            foreach (int i in fib)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}