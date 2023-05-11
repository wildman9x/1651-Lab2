using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                StudentID = Guid.NewGuid().ToString(),
                Name = "John",
                DateOfBirth = new DateTime(1990, 1, 1),
                Address = "123 Main St",
                Phone = "123-456-7890",
                Email = "john@gmail.com",
                Grades = new Dictionary<string, double>()
                {
                    {"C# Programming", 95},
                    {"Database", 85},
                    {"Web Development", 90},
                    {"Math", 100},
                    {"English", 80},
                    {"Physics", 75}
                },
            };
            // Print grade of math
            Console.WriteLine("Grade of Math: " + student1.Grades["Math"]);
            // Print GPA
            Console.WriteLine("GPA: " + student1.CalculateGPA());
            // Print student info
            student1.PrintInfo();

            Dictionary<string, Product> products = new Dictionary<string, Product>();
            products.Add("iPhone 6", new Product()
            {
                Name = "iPhone 6",
                ManufactureDate = new DateTime(2016, 1, 1),
                ExpiryDate = new DateTime(2018, 1, 1),
                Price = 500
            });
            products.Add("iPhone 7", new Product()
            {
                Name = "iPhone 7",
                ManufactureDate = new DateTime(2017, 1, 1),
                ExpiryDate = new DateTime(2019, 1, 1),
                Price = 600
            });
            products.Add("iPhone 8", new Product()
            {
                Name = "iPhone 8",
                ManufactureDate = new DateTime(2018, 1, 1),
                ExpiryDate = new DateTime(2020, 1, 1),
                Price = 700
            });
            products.Add("iPhone X", new Product()
            {
                Name = "iPhone X",
                ManufactureDate = new DateTime(2019, 1, 1),
                ExpiryDate = new DateTime(2021, 1, 1),
                Price = 800
            });

            // Add a product
            AddProduct(products);

            // Search for a product by name
            SearchProduct(products);
        }

        private static void SearchProduct(Dictionary<string, Product> products)
        {
            Console.WriteLine("Search for a product by name: ");
            string name = Console.ReadLine();
            if (products.ContainsKey(name))
            {
                products[name].PrintInfo();
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private static void AddProduct(Dictionary<string, Product> products)
        {
            Console.WriteLine("Add a product: ");
            string name = Console.ReadLine();
            if (products.ContainsKey(name))
            {
                Console.WriteLine("Product already exists!");
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
                products.Add(name, product);
            }
        }
    }
}