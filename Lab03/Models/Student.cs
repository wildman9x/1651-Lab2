using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03.Models
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Class { get; set; }
        public string School { get; set; }

        public Student(){

        }

        public override void PrintInfo(){
            base.PrintInfo();
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("School: " + School);
        }
    }
}