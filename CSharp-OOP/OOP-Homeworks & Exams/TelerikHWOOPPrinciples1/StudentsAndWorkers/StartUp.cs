namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student("Diego","Maradona",3),
                new Student("Cenko","Chokov", 4),
                new Student("Boko","Chokov", 5),
            };

            var sortedByGrade = listOfStudents.OrderBy(st => st.Grade).ThenBy(st => st.FirstName);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorted students by grades: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student + " " + student.Grade);
            }

            Console.WriteLine(new string('-', 50));

            // workers sorted by salary in descending order

            var listOfWorkers = new List<Worker>
            {
                new Worker("Penka","Petrova",252,7),
                new Worker("Hristofor","Gacov",400,5),
                new Worker("Trendafil","Trendafilov",1230,8),
                new Worker("John","Johnson",770,8),

            };

            var sortedBySalary = listOfWorkers.OrderByDescending(w => w.MoneyPerHours());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Workers sorted by money per hour in descending order: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var worker in sortedBySalary)
            {
                Console.WriteLine(worker + " - " + worker.MoneyPerHours());
            }

            Console.WriteLine(new string('-', 50));

            // all people sorted by name

            var mergedList = listOfStudents.Concat<Human>(listOfWorkers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("All people sorted by name: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var person in mergedList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
