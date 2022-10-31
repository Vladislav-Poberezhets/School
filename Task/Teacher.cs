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
        
        
        public Teacher()
        {

        }

        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
           
        }

        public void ChangeInfTeacher(Teacher teacher)
        {
            teacher.Name = Console.ReadLine();
            Name = teacher.Name;
            teacher.Age = int.Parse(Console.ReadLine());
            Age = teacher.Age;

            
        }

    }
}
