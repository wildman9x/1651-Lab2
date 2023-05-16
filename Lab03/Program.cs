using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;
using Lab03.Public;

namespace Lab03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                MenuDict.PrepareMenu(MenuDict.GetMenu(typeof(MainMenuItem)));
                Console.Clear();
            }
        }
    }
}