using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;

namespace Lab03.Menu
{
    public class DeleteStudent : MainMenuItem
    {
        public string GetName()
        {
            return "Delete Student";
        }

        public void Run()
        {
            Console.WriteLine("Delete Student");
        }
    }
}