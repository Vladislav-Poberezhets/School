using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Pupils
    {

        private List<Pupil> PupilsList = new List<Pupil>();

        public void AddPupil(Pupil pupil)
        {
            
            PupilsList.Add(pupil);

        }

        public void Show()
        {
            foreach (Pupil pupil in PupilsList)
            {
                Console.WriteLine(pupil.ToString());
            }
        }


    }


    
}
