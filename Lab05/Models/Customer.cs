using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Singleton;

namespace Lab05.Models
{
    public class Customer
    {
        public string Name {get; set;} = "Unnamed Customer";
        public int ID {get; set;} = CustomerDict.Instance.Customers.Count;
        public string Phone {get; set;} = "0000000000";
        public string Address {get; set;} = "No Address";

        public Customer()
        {
            
        }

        public string GetInfo()
        {
            return $"ID: {ID}\nName: {Name}\nPhone: {Phone}\nAddress: {Address}";
        }
    }
}