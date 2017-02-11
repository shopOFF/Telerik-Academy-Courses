namespace Animals
{
    using System;
    using System.Collections.Generic;
    public class AnimalsStratUp
    {
        public static void Main()
        {
            var catList = new List<Cat>
            {
                new Cat("Balkan", 3, Gender.Male, "Siamese"),
                new Tomcat("Cotangens", 4, "Persian"),
                new Kitten("Vihur", 1, "British blue"),
                new Cat("Lucifer", 13, Gender.Something,"Maine Coon")
            };

            Console.WriteLine("Cats average age: {0:F2}", Animal.AnimalAverageAge(catList)); // Using Animal class static method

            var dogList = new List<Dog>
            {
                new Dog("Nikodim", 15, Gender.Something, "Street Finest"),
                new Dog("Topcho", 5, Gender.Female, "Siberian Husky"),
                new Dog("Shukar", 7, Gender.Male, "Retriever"),
                new Dog("Abraham", 2, Gender.Female, "German Shepherd"),
                new Dog("Dochka",17,Gender.Female,"Alabai")
            };

            Console.WriteLine("Dogs average age: {0:F2}", Animal.AnimalAverageAge(dogList)); // Using Animal class static method

            var frogList = new List<Frog>
            {
                new Frog("Atanas",70,Gender.Female,"Bubble Frog"),
                new Frog("Jabba the Slutt", 100,Gender.Something,"Bullfrog"),
                new Frog("Drisko",10,Gender.Male,"Goliath Frog"),
                new Frog("Evstatii",17,Gender.Female,"Cane Toad")
            };

            Console.WriteLine("Frogs average age: {0:F2}", Animal.AnimalAverageAge(frogList)); // Using Animal class static method
        }
    }
}
