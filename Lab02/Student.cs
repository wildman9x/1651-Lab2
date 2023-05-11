using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02
{
    public class Student
    {
        public string Name { get; set; }
        // DOB
        public DateTime DateOfBirth { get; set; }
        // Address
        public string Address { get; set; }
        // Phone
        public string Phone { get; set; }
        // Email
        public string Email { get; set; }
        // Student ID
        public string StudentID { get; set; }
        // Dictionary of grade
        public Dictionary<string, double> Grades { get; set; } = new Dictionary<string, double>();

        public Student()
        {
            
        }

        // add grade
        public void AddGrade(string course, double grade)
        {
            Grades.Add(course, grade);
        }

        // calculate GPA
        public double CalculateGPA()
        {
            double total = 0;
            foreach (var grade in Grades)
            {
                total += grade.Value;
            }
            return total / Grades.Count;
        }

        // print student info
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Date of Birth: " + DateOfBirth);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("GPA: " + CalculateGPA());
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade.Key + ": " + grade.Value);
            }
        }
    }
}