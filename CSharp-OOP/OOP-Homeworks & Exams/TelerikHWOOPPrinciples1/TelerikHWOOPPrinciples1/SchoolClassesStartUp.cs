namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolClassesStartUp
    {
        public static void Main()
        {

            var nikodimStudent = new Student("Nikodim", "Nikodimov", 13);
            var cenkoStudent = new Student("Cenko", "Chokov", 666);
            var diegoStudent = new Student("Diego", "Maradona", 10);

            Console.WriteLine(diegoStudent.ToString());

            var math = new Discipline("Mathematics", 5, 3);
            var english = new Discipline("English", 10, 5);
            var biology = new Discipline("Biology", 3, 1);


            var gichkaTeacher = new Teacher("Gichka", "Dimitrichkova");
            gichkaTeacher.AddDiscipline(english);
            gichkaTeacher.AddDiscipline(biology);

            var penkaTeacher = new Teacher("Penka", "Penkiova");
            gichkaTeacher.AddDiscipline(english);
            gichkaTeacher.AddDiscipline(biology);

            List<Teacher> teachersForAClass = new List<Teacher>() { gichkaTeacher, penkaTeacher };

            diegoStudent.AddComment("It's me Maradona!");
            Console.WriteLine(diegoStudent.ShowComments());


        }
    }
}
