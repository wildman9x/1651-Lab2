using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Lab05.Interface;
using Lab05.Models;

namespace Lab05.Strategy.OrderStrategy
{
    public class ByCustomerName : OrderSearchStrategy
    {
        public void Search(Dictionary<int, Order> orders, List<OrderDetail> orderDetails, Dictionary<int, Product> products, Dictionary<int, Customer> customers)
        {
            Console.WriteLine("Search by Customer Name");
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();
            try
            {
                var orderResult = orders.Values.Where(o => customers[o.CustomerID].Name.ToLower().Contains(name.ToLower()));
                if (orderResult.Count() == 0)
                {
                    Console.WriteLine("Customer Name not found");
                    return;
                }
                foreach (var order in orderResult) {
                    Console.WriteLine($"Order ID: {order.ID}\nCustomer ID: {order.CustomerID}\nCustomer Name: {customers[order.CustomerID].Name}\nDate Created: {order.DateCreated}\nTotal Price: {order.TotalPrice}");
                    var table = new ConsoleTable("Product", "Unit Price", "Quantity", "Total Price");
                    foreach (var orderDetail in orderDetails)
                    {
                        if (orderDetail.OrderID == order.ID)
                        {
                            var product = products[orderDetail.ProductID];
                            table.AddRow(product.Name, product.Price, orderDetail.Quantity, orderDetail.Quantity * product.Price);
                        }
                    }
                    table.Write();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Customer Name not found");
            }
        }
    }
}