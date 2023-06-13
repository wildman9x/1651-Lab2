using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Models;

namespace Lab05.Singleton
{
    public class OrderDict
    {
        private OrderDict()
        {
        }
        private static OrderDict _instance;
        private static readonly object _lock = new object();
        public static OrderDict Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderDict();
                    }
                    return _instance;
                }
            }
        }
        public Dictionary<int, Order> Orders { get; set; } = new ();
        public void Add(Order order)
        {
            this.Orders.Add(order.ID, order);
        }
        public void Remove(int id)
        {
            this.Orders.Remove(id);
        }
        public void Update(int id, Order order)
        {
            this.Orders[id] = order;
        }
        public Order Get(int id)
        {
            return this.Orders[id];
        }
        public List<Order> GetAll() {
            return this.Orders.Values.ToList();
        }
    }
}