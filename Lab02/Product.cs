using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02
{
    public class Product
    {
        public string Name { get; set; }
        // Manufacture date
        public DateTime ManufactureDate { get; set; }
        // Expiry date
        public DateTime ExpiryDate { get; set; }
        // Price
        public double Price { get; set; }

        public Product()
        {
            
        }

        // check expiry
        public bool CheckExpiry()
        {
            return DateTime.Now > ExpiryDate;
        }

        // print product info
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Manufacture Date: " + ManufactureDate);
            Console.WriteLine("Expiry Date: " + ExpiryDate);
            Console.WriteLine("Price: " + Price);
        }
    }
}