using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        public static Student[] filterStudents(Student[] students)
        {
            var filteredStudents = students
                .Where(st => string.Compare(st.FirstName, st.LastName) < 0)
                .ToArray();

            return filteredStudents;
        }
        static void Main(string[] args)
        {
            var students = new[]
           {
                new Student{ FirstName = "Ivan", LastName = "Ivanov", Age = 19},
                new Student{ FirstName = "Petyr", LastName = "Petrov", Age = 23},
                new Student{ FirstName = "Dragan", LastName = "Ivanov", Age = 18},
                new Student{ FirstName = "Stoqn", LastName = "Ashev", Age = 19 },
                new Student{ FirstName = "Stoqn", LastName = "Beshev", Age = 25 },
                new Student{ FirstName = "Tordromil", LastName = "Strahilov", Age = 28 }
            };


            // Task 3
            var filteredStudents = filterStudents(students);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }


            Console.WriteLine(new string('-', 30));
            Console.WriteLine();


            // Task 4
            var youngStudents = students
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .Select(st => st.FirstName + " " + st.LastName);

            foreach (var student in youngStudents)
            {
                Console.WriteLine(student);
            }


            Console.WriteLine(new string('-', 30));
            Console.WriteLine();


            // Task 5
            var orderStudents = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            foreach (var student in orderStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }


            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
    }
}
