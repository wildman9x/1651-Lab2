using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Interface;
using Lab05.Models;
using Lab05.Singleton;

namespace Lab05.Context
{
    public class OrderSearchContext
    {
        private Dictionary<int, Product> Products { get; set; } = ProductDict.Instance.Products;
        private Dictionary<int, Order> Orders { get; set; } = OrderDict.Instance.Orders;
        private List<OrderDetail> OrderDetails { get; set; } = OrderDetailList.Instance.OrderDetails;
        public OrderSearchStrategy Strategy { get; set; }
        public void RunStrategy(){
            this.Strategy.Search(this.Orders, this.OrderDetails, this.Products);
        }
    }
}