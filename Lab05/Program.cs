﻿using System;
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
        ProductDict.Instance.Add(new Product() { Name = "Product 1", Price = 1.0f, Size = 1, Quantity = 1 });
        ProductDict.Instance.Add(new Product() { Name = "Product 2", Price = 2.0f, Size = 2, Quantity = 2 });
        ProductDict.Instance.Add(new Product() { Name = "Product 3", Price = 3.0f, Size = 3, Quantity = 3 });
        ProductDict.Instance.Add(new Product() { Name = "Product 4", Price = 4.0f, Size = 4, Quantity = 4 });

        var table = new ConsoleTable("ID", "Name", "Price", "Size", "Quantity");
        foreach (var product in ProductDict.Instance.GetAll())
        {
            table.AddRow(product.ID, product.Name, product.Price, product.Size, product.Quantity);
        }
        table.Write();

        CustomerDict.Instance.Add(new Customer() { Name = "Customer 1", Phone = "1111111111", Address = "Address 1" });
        CustomerDict.Instance.Add(new Customer() { Name = "Customer 2", Phone = "2222222222", Address = "Address 2" });
        CustomerDict.Instance.Add(new Customer() { Name = "Customer 3", Phone = "3333333333", Address = "Address 3" });
        CustomerDict.Instance.Add(new Customer() { Name = "Customer 4", Phone = "4444444444", Address = "Address 4" });

        table = new ConsoleTable("ID", "Name", "Phone", "Address");
        foreach (var customer in CustomerDict.Instance.GetAll())
        {
            table.AddRow(customer.ID, customer.Name, customer.Phone, customer.Address);
        }
        table.Write();

        // add 1 admin and 3 staff
        UserDict.Instance.Add(new Admin() { FullName = "Admin 1", Username = "admin1", Password = "admin1" });
        UserDict.Instance.Add(new Staff() { FullName = "Staff 1", Username = "staff1", Password = "staff1" });
        UserDict.Instance.Add(new Staff() { FullName = "Staff 2", Username = "staff2", Password = "staff2" });
        UserDict.Instance.Add(new Staff() { FullName = "Staff 3", Username = "staff3", Password = "staff3" });

        table = new ConsoleTable("ID", "Full Name", "Username", "Password", "Role");
        foreach (var user in UserDict.Instance.GetAll())
        {
            table.AddRow(user.ID, user.FullName, user.Username, user.Password, user.GetType().Name);
        }
        table.Write();
        while (true)
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Search Order");
            Console.WriteLine("2. Search Product");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    var context = new OrderSearchContext();
                    List<OrderSearchStrategy> strategies = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(OrderSearchStrategy).IsAssignableFrom(t))
            .Select(t => Activator.CreateInstance(t) as OrderSearchStrategy).ToList();
                    Dictionary<int, OrderSearchStrategy> strategiesDict = new();
                    foreach (var strategy in strategies)
                    {
                        strategiesDict.Add(strategiesDict.Count, strategy);
                    }
                    Console.WriteLine("Choose search strategy:");
                    foreach (var strategy in strategiesDict)
                    {
                        // get type name from strategy and separate by camel case
                        string strategyName = NameNormalization.CamelCase(strategy.Value.GetType().Name);
                        Console.WriteLine($"{strategy.Key}. {strategyName}");
                    }
                    try
                    {
                        int strategyChoice = int.Parse(Console.ReadLine());
                        context.Strategy = strategiesDict[strategyChoice];
                        context.RunStrategy();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
