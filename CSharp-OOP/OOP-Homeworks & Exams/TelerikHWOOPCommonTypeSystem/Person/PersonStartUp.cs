namespace Person
{
    using System;
    public class PersonStartUp
    {
        public static void Main()
        {
            var firstPerson = new Person("Pesho", null);
            var secondPerson = new Person("Stamat", 24);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
