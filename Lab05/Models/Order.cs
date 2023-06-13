using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab05.Models
{
    public class Order
    {
        public int ID { get; private set; } 
        public int CustomerID { get; set; }
        public float TotalPrice { get; private set; }
        public DateTime DateCreated { get; private set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public Order()
        {
            
        }

    }
}