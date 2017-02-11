namespace Schools
{
    using System;
    using Schools.Disciplines;
    using Schools.ExceptionVerification;
    using Schools.Interfaces;
    using Schools.People;
    using Schools.SchoolClasses;

    class Test
    {
        static void Main(string[] args)
        {
            var techearPenka = new Teacher("Penka");
            var classPenka = new SchoolClass("11A");

            Console.WriteLine(techearPenka.Name);
            Console.WriteLine(techearPenka.Disciplines.Capacity);

            //you can try other tests here
        }
    }
}