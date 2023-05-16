using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;

namespace Lab03.Menu.SubMenu.SearchStudentMenuItems
{
    public class ByName : SearchStudentMenuItem
    {
        public string GetName()
        {
            return "Search by Name";
        }

        public void Run()
        {
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();
            var found = false;
            foreach (var student in GlobalVar.StudentDict)
            {
                if (student.Value.Name == name)
                {
                    student.Value.PrintInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}