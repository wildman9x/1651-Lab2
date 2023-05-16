using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;

namespace Lab03.Menu.SubMenu.SearchStudentMenuItems
{
    public class ById : SearchStudentMenuItem
    {
        public string GetName()
        {
            return "Search by ID";
        }

        public void Run()
        {
            Console.Write("Enter ID: ");
            var id = Console.ReadLine();
            if (GlobalVar.StudentDict.ContainsKey(id))
            {
                GlobalVar.StudentDict[id].PrintInfo();
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}