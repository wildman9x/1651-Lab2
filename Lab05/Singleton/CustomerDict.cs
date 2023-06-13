using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Models;

namespace Lab05.Singleton
{
    public class CustomerDict
    {
        private CustomerDict()
        {
        }
        private static CustomerDict _instance;
        private static readonly object _lock = new object();
        public static CustomerDict Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CustomerDict();
                    }
                    return _instance;
                }
            }
        }
        public Dictionary<int, Customer> Customers { get; set; } = new ();
        public void Add(Customer customer)
        {
            this.Customers.Add(customer.ID, customer);
        }
        public void Remove(int id)
        {
            this.Customers.Remove(id);
        }
        public void Update(int id, Customer customer)
        {
            this.Customers[id] = customer;
        }
        public Customer Get(int id)
        {
            return this.Customers[id];
        }
        public List<Customer> GetAll()
        {
            return this.Customers.Values.ToList();
        }
    }
}