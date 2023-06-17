using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Singleton;

namespace Lab05.Models
{
    public class Order
    {
        public int ID { get; set; } = OrderDict.Instance.Orders.Count;
        public int CustomerID { get; set; }
        public int CreatorID { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public Order()
        {
            
        }

    }
}