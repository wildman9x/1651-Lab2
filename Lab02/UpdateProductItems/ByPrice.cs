using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.UpdateProductItems
{
    public class ByPrice : IUpdateProduct
    {
        public string GetName()
        {
            return "By Price";
        }

        public void Run()
        {
            Console.WriteLine("Update by price");
            // Search by name but update only the price
            foreach (var product in Program.products)
            {
                Console.WriteLine(product.Key);
            }
            Console.WriteLine("Enter the name of the product you want to update: ");
            string name = Console.ReadLine();
            if (Program.products.ContainsKey(name))
            {
                Console.WriteLine("Enter the new price of the product: ");
                double newPrice = double.Parse(Console.ReadLine());
                Program.products[name].Price = newPrice;
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}