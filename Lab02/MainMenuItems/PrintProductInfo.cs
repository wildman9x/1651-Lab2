using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.MainMenuItems
{
    public class PrintProductInfo : MainMenuItem
    {
        public string GetName()
        {
            return "Print a product info";
        }

        public void Run()
        {
            foreach (var product in Program.products)
            {
                product.Value.PrintInfo();
            }
        }
    }
}