using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lab05.Models;
using Lab05.Singleton;
using ConsoleTables;
using Lab05.Context;
using Lab05.Interface;
using Lab05.Public;

namespace Lab05;
class Program
{
    static void Main(string[] args)
    {
        GenerateData();
        while (true)
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Search Order");
            Console.WriteLine("2. Search Product");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        MenuPrepare.Prepare<OrderSearchStrategy, OrderSearchContext>();
                        break;
                    case 2:
                        MenuPrepare.Prepare<ProductSearchStrategy, ProductSearchContext>();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void GenerateData()
    {
        // random price, random size, random quantity in a range
        for (int i = 0; i < 100; i++)
        {
            ProductDict.Instance.Add(new Product() { Name = $"Product {i}", Price = (float)Math.Round(new Random().NextSingle() * (500 - 15) + 15, 2), Size = new Random().Next(32, 43), Quantity = new Random().Next(20, 1000) });
        }

        var table = new ConsoleTable("ID", "Name", "Price", "Size", "Quantity");
        foreach (var product in ProductDict.Instance.GetAll())
        {
            table.AddRow(product.ID, product.Name, product.Price, product.Size, product.Quantity);
        }
        table.Write();
        // Random phone number that follows the format 0xxxxxxxxx, x are all number
        for (int i = 0; i < 20; i++)
        {
            CustomerDict.Instance.Add(new Customer() { Name = $"Customer {i}", Phone = $"0{new Random().Next(100000000, 999999999)}", Address = $"Address {i}" });
        }

        table = new ConsoleTable("ID", "Name", "Phone", "Address");
        foreach (var customer in CustomerDict.Instance.GetAll())
        {
            table.AddRow(customer.ID, customer.Name, customer.Phone, customer.Address);
        }
        table.Write();

        // add 1 admin and 3 staff
        UserDict.Instance.Add(new Admin() { FullName = "Admin 1", Username = "admin1", Password = "admin1" });
        for (int i = 0; i < 5; i++)
        {
            UserDict.Instance.Add(new Staff() { FullName = $"Staff {i}", Username = $"staff{i}", Password = $"staff{i}" });
        }

        table = new ConsoleTable("ID", "Full Name", "Username", "Password", "Role");
        foreach (var user in UserDict.Instance.GetAll())
        {
            table.AddRow(user.ID, user.FullName, user.Username, user.Password, user.GetType().Name);
        }
        table.Write();
        // Generate 10 orders
        for (int i = 0; i < 10; i++)
        {
            OrderDict.Instance.Add(new Order()
            {
                CustomerID = CustomerDict.Instance.Customers[new Random().Next(0, 19)].ID,
                CreatorID = UserDict.Instance.Users[new Random().Next(1, 6)].ID,
                DateCreated = DateTime.Now.AddDays(new Random().Next(-100, 0))
            });
        }

        // Generate from 1 to 5 order details for each order
        foreach (var order in OrderDict.Instance.GetAll())
        {
            order.TotalPrice = 0;
            for (int i = 0; i < new Random().Next(1, 5); i++)
            {
                int quantity = new Random().Next(1, 10);
                int productID = ProductDict.Instance.Products[new Random().Next(0, 99)].ID;
                OrderDetailList.Instance.Add(new OrderDetail()
                {
                    OrderID = order.ID,
                    ProductID = productID,
                    Quantity = quantity,
                    Price = ProductDict.Instance.Products[productID].Price * quantity
                });
                order.TotalPrice += OrderDetailList.Instance.OrderDetails.Last().Price;
                // Console.WriteLine(order.TotalPrice.ToString());
                // Console.WriteLine(OrderDetailList.Instance.OrderDetails.Last().ProductID);
            }
        }
        // Display all orders, first display all the information in the order in text, then display the order details in a table
        foreach (var order in OrderDict.Instance.GetAll())
        {
            Console.WriteLine($"Order ID: {order.ID}\nCustomer: {CustomerDict.Instance.Customers[order.CustomerID].Name}\nCreator: {UserDict.Instance.Users[order.CreatorID].FullName}\nDate Created: {order.DateCreated}\nTotal Price: {order.TotalPrice}");
            table = new ConsoleTable("Product Name", "Unit Price", "Quantity", "Total Price");
            foreach (var orderDetail in OrderDetailList.Instance.GetAll())
            {
                if (orderDetail.OrderID == order.ID)
                {
                    table.AddRow(ProductDict.Instance.Products[orderDetail.ProductID].Name, ProductDict.Instance.Products[orderDetail.ProductID].Price, orderDetail.Quantity, orderDetail.Price);
                }
            }
            table.Write();
        }
    }
}
