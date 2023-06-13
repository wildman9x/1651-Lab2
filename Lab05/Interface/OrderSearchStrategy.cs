using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Models;

namespace Lab05.Interface
{
    public interface OrderSearchStrategy
    {
        public void Search (Dictionary<int, Order> orders, List<OrderDetail> orderDetails, Dictionary<int, Product> products);
    }
}