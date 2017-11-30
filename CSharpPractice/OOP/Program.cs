using OOP.Composition;
using OOP.Inheritance;
using OOP.Inheritance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var animal = new Animal() { Age = 3, Name = "Pesho" };
            var cat = new Cat() { Age = 113, Name = "Gesho" };
            var dog = new Dog() { Age = 13, Name = "Misho" };

            var listOfAnimals = new List<IAnimal>() { animal, cat, dog };

            foreach (var item in listOfAnimals)
            {
                Console.WriteLine(item.SaySomething());
            }

            ////////////
            Console.WriteLine("///////////////");
            var animalComp = new AnimalComposition() { Age = 32, Name = "Pesho" };
            Console.WriteLine(animalComp);

            var dogComp = new DogComposition(animalComp, new Walk());

            Console.WriteLine(dogComp);
        }
    }
}
