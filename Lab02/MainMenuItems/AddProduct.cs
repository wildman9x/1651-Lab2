using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab02.Interface;

namespace Lab02.MainMenuItems
{
    public class AddProduct : MainMenuItem
    {
        public string GetName()
        {
            return "Add Product";
        }

        public void Run()
        {
            // How many products do you want to add?
            Console.WriteLine("How many products do you want to add?");
            try
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Add a product: ");
                    string name = Console.ReadLine();
                    if (Program.products.ContainsKey(name))
                    {
                        Console.WriteLine("Product already exists!");
                        i--;
                    }
                    else
                    {
                        Product product = new Product();
                        product.Name = name;
                        Console.WriteLine("Manufacture Date: ");
                        product.ManufactureDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Expiry Date: ");
                        product.ExpiryDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Price: ");
                        product.Price = double.Parse(Console.ReadLine());
                        Program.products.Add(name, product);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}