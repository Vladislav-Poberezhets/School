using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Class
    {
        private static List<Pupils> Pupils;


        public static void AddPupil(Pupils pupil, List<Pupils> pupils)
        {
            
            pupils.Add(pupil);
            Pupils = pupils;
            /*foreach (var p in pupils)
            {
                Console.WriteLine(pupil);
            }*/

        }

        public void Print()
        {
            foreach( var p in Pupils)
            {
                Console.WriteLine(p);
            }
        }
    }


    
}
