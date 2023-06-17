using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Lab05.Interface;
using Lab05.Models;

namespace Lab05.Strategy.OrderStrategy
{
    public class ByID : OrderSearchStrategy
    {
        public void Search(Dictionary<int, Order> orders, List<OrderDetail> orderDetails, Dictionary<int, Product> products, Dictionary<int, Customer> customers)
        {
            Console.WriteLine("Search by ID");
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                var table = new ConsoleTable("ID", "Customer", "Date", "Total");
                var order = orders[id];
                table.AddRow(order.ID, order.CustomerID, order.DateCreated, order.TotalPrice);
                Console.WriteLine($"Order ID: {order.ID}/nCustomer ID: {order.CustomerID}/nCustomer Name: {customers[order.CustomerID].Name}/nDate Created: {order.DateCreated}/nTotal Price: {order.TotalPrice}");
                table.Write();
                Console.WriteLine("Order Details");
                var table2 = new ConsoleTable("Product", "Price", "Quantity");
                foreach (var orderDetail in orderDetails)
                {
                    if (orderDetail.OrderID == id)
                    {
                        var product = products[orderDetail.ProductID];
                        table2.AddRow(product.Name, product.Price, orderDetail.Quantity);
                    }
                }
                table2.Write();
            }
            catch (Exception)
            {
                Console.WriteLine("ID not found");
            }
        }
    }
}