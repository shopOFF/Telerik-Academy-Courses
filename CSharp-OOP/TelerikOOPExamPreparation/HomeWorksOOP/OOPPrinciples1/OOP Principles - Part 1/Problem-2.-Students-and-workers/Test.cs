namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using StudentsAndWorkers.Humans;
    using System.Collections.Generic;

    class Test
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Robert", "Robertov", 5));
            students.Add(new Student("Tisho", "Tishov", 2));
            students.Add(new Student("Koko", "Kokov", 3));
            students.Add(new Student("Jordan", "Jordanov", 6));
            students.Add(new Student("Luna", "Lunava", 7));
            students.Add(new Student("Eva", "Mendez", 1));
            students.Add(new Student("Ivan", "Ivanov", 2));
            students.Add(new Student("Lorem", "Ipsumov", 2));
            students.Add(new Student("Pesho", "Peshov", 12));
            students.Add(new Student("Petar", "Petrov", 11));

            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var orderedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Students ordered by Grade: ");
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Pesho", "Tupoto", 1200, 12));
            workers.Add(new Worker("Gosho", "Umnoto", 234, 14));
            workers.Add(new Worker("Tosho", "Bosa", 5223, 8));
            workers.Add(new Worker("John", "Kompira", 12315, 6));
            workers.Add(new Worker("Hohn", "Fichkata", 2351, 3));
            workers.Add(new Worker("HoHoHohn", "Zvero", 2321, 5));
            workers.Add(new Worker("Hail", "Hitler", 23123, 6));
            workers.Add(new Worker("Musulini", "Ivanov", 23215, 7));
            workers.Add(new Worker("Franco", "Toshov", 1800, 2));
            workers.Add(new Worker("Stalin", "Goshov", 7666, 1));

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Workers ordered by MoneyPerHour: ");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + " - Money per hour: " + worker.MoneyPerHour());
            }

            //Merge the lists and sort them by first name and last name.

            Console.WriteLine();
            Console.WriteLine();
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortedHumans =
                from h in humans
                orderby h.FirstName ascending
                , h.LastName ascending
                select h;
            Console.WriteLine("Sorted humans:");
            foreach (var h in sortedHumans)
            {
                Console.WriteLine(h);
            }
        }
    }
}