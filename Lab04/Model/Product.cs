using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Singleton;

namespace Lab04.Model
{
    public class Product
    {
        public int ID { get; set; } = ProductIDCount.Instance.Count;
        public string Name { get; set; }
        public double Price { get; set; }
        public Product()
        {
            ProductIDCount.Instance.Increase();
        }
        public Product(string name, double price)
        {
            ProductIDCount.Instance.Increase();
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ID: {this.ID}, Name: {this.Name}, Price: {this.Price}";
        }
    }
}