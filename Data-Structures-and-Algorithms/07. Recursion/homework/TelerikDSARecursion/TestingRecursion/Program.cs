using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingRecursion
{
    public class Program
    {
        private static int numberOfLoops;

        static void TestingRecursion(int loops)
        {
            if (loops <= 0)
            {
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("I Before");
            }
            Console.WriteLine("Index DOWN  Loop: {0}", loops);
                TestingRecursion(loops - 1);
                Console.WriteLine("Index UP  Loop: {0}",loops);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("I After");
            }
        }

        public static void Main()
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            TestingRecursion(numberOfLoops);
        }
    }
}
