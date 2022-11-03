namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil = new Pupil("Vlad", 24);

            var pupil2 = new Pupil("Vadim", 22);

            Pupils classA = new Pupils();

            classA.AddPupil(pupil);

            classA.AddPupil(pupil2);

            classA.Show();

            var teacher = new Teacher("Olga", "Andreevna", 42);

            teacher.UpdateTeacher();

            teacher.Show();



            var Monday = new List<Lesson>()
            {
                new Lesson ("Biology", TimeOnly.FromDateTime(DateTime.Now)),
                new Lesson ("Math", TimeOnly.FromDateTime(DateTime.Now.AddMinutes(-55))),
                new Lesson ("Geography", TimeOnly.FromDateTime(DateTime.Now.AddMinutes(-55)))

            };

            foreach (var lesson in Monday)
                Console.WriteLine(lesson);

           


            

            
            

            /*var teacher = new Teacher("Vlad", 67);*/










        }
    }
}