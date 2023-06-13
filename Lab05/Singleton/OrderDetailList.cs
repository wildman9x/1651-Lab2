using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Models;

namespace Lab05.Singleton
{
    public class OrderDetailList
    {
        private OrderDetailList()
        {
        }
        private static OrderDetailList _instance;
        private static readonly object _lock = new object();
        public static OrderDetailList Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderDetailList();
                    }
                    return _instance;
                }
            }
        }
        public List<OrderDetail> OrderDetails { get; set; } = new ();
        public void Add(OrderDetail orderDetail)
        {
            this.OrderDetails.Add(orderDetail);
        }
        public void Remove(int id)
        {
            this.OrderDetails.RemoveAt(id);
        }
        public void Update(int id, OrderDetail orderDetail)
        {
            this.OrderDetails[id] = orderDetail;
        }
        public OrderDetail Get(int id)
        {
            return this.OrderDetails[id];
        }
        public List<OrderDetail> GetAll()
        {
            return this.OrderDetails;
        }
    }
}