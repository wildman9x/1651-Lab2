using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;

namespace Lab03.Menu
{
    public class ShowStudents : MainMenuItem
    {
        public string GetName()
        {
            return "Show All Students";
        }

        public void Run()
        {
            Console.WriteLine("List of all students:");
            foreach (var student in GlobalVar.StudentDict)
            {
                student.Value.PrintInfo();
            }
        }
    }
}