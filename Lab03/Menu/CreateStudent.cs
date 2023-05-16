using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Interface;
using Lab03.Models;

namespace Lab03.Menu
{
    public class CreateStudent : MainMenuItem
    {
        public string GetName()
        {
            return "Create Student";
        }

        public void Run()
        {
            Console.WriteLine("Please enter the student's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the student's date of birth (dd/mm/yyyy):");
            DateOnly birthday = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the student's ID:");
            string studentId = Console.ReadLine();
            Console.WriteLine("Please enter the student's class:");
            string class_ = Console.ReadLine();
            Console.WriteLine("Please enter the student's school:");
            string school = Console.ReadLine();
            Student student = new Student() {
                Name = name,
                Birthday = birthday,
                StudentId = studentId,
                Class = class_,
                School = school
            };
            GlobalVar.StudentDict.Add(studentId, student);
            Console.WriteLine("Student created successfully!");
        }
    }
}