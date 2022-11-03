using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
   class Lesson
    {

        private TimeOnly Time { get; set; }
        private string Name { get; set; }


        public Lesson(string name, TimeOnly time)
        {
            Time = time;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} - {Time:HH:mm}"; 
        }
    }



    
}
