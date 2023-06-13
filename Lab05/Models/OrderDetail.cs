using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Singleton;

namespace Lab05.Models
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; } = 1;
        public float Price { get; private set; }
        public OrderDetail()
        {
            this.Price = ProductDict.Instance.Products[ProductID].Price * Quantity;
        }
    }
}