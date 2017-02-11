using System;

namespace Task14Labyrinth
{
    public class StartUp
    {
        public static void Main()
        {
            var lab = new Labyrinth(10);

            Console.WriteLine("Empty labyrinth:\n");
            lab.Print();
            Console.WriteLine();
            lab.Fill();
            Console.WriteLine("Filled labyrinth:\n");
            lab.Print();
        }
    }
}
