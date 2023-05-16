using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03.Models
{
    public class Person
    {
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Person(){

        }

        public virtual void PrintInfo(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Birthday: " + Birthday);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone number: " + PhoneNumber);
            Console.WriteLine("Email address: " + EmailAddress);
        }
    }
}