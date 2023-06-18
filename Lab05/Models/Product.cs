using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Singleton;

namespace Lab05.Models
{
    public class Product
    {
        public string Name {get; set;} = "Unnamed Product";
        public int ID {get; set;} = ProductDict.Instance.Products.Count;
        public float Price {get; set;}
        public int Size {get; set;}
        public int Quantity {get; set;}
        public Product () {
        }
        public string GetInfo() {
            return $"Name: {this.Name}\nID: {this.ID}\nPrice: {this.Price}\nSize: {this.Size}\nQuantity: {this.Quantity}";
        }
    }
}