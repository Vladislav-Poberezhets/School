using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Teacher
    {
        private string Name { get; set; }
        private int Age { get; set; }

        private string MiddleName { get; set; }
        string AboutTeacher { get; set; }

        public Teacher()
        {

        }
        public Teacher(string name, string middleName, int age)
        {
            Name = name;
            Age = age;
            MiddleName = middleName;    
        }

        public void UpdateTeacher()
        {

            Console.WriteLine("Enter additional information about the teacher:");
            AboutTeacher = Console.ReadLine();
            
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}, Additional: {AboutTeacher}");
        }
    }
}
