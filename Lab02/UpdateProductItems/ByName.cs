using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.UpdateProductItems
{
    public class ByName : IUpdateProduct
    {
        public string GetName()
        {
            return "Update by Name";
        }

        public void Run()
        {
            Console.WriteLine("Update by Name");
            foreach (var product in Program.products)
            {
                Console.WriteLine(product.Key);
            }
            Console.WriteLine("Enter the name of the product you want to update: ");
            string name = Console.ReadLine();
            // only update the name of the product
            if (Program.products.ContainsKey(name))
            {
                Console.WriteLine("Enter the new name of the product: ");
                string newName = Console.ReadLine();
                Program.products[newName] = Program.products[name];
                Program.products.Remove(name);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}