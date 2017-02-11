namespace StudentClass
{
    using System;
    using Enums;
    public class StartUp
    {
        public static void Main()
        {
            var peshoStudent = new Student("Pesho", "Stamatov", "Peshov", 1313, "Bacova mahala", "0877775423", "pesho@gmail.com", 2, Universities.UNIBIT, Faculties.ComputerScience, Specialties.ComputerScience);

            var joroStudent = new Student("John", "Georgiev", "Peshev", 2034, "7'th street", "0892335423", "joro@abv.bg", 4, Universities.TU, Faculties.Telecomunications, Specialties.Tellecomunications);

            Console.WriteLine(peshoStudent.ToString());  // Task 1
            Console.WriteLine("HashCode: {0}", peshoStudent.GetHashCode()); // Task 1
            Console.WriteLine(peshoStudent.Equals(joroStudent)); // Task 1
            Console.WriteLine(peshoStudent == joroStudent);
            Console.WriteLine(peshoStudent != joroStudent);

            var cloneStudent = peshoStudent.Clone(); // Task 2
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(cloneStudent.ToString());

            Console.WriteLine(peshoStudent.CompareTo(joroStudent)); // Task 3
        }
    }
}
