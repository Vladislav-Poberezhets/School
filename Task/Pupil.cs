using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Pupil
    {
        private string name;
        private int age;
        


        public Pupil()
        {

        }
        public Pupil(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }
        public override string ToString()
        {
            return name + " " + age;
        }











    }
}
