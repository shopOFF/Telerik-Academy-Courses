using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6RemoveAllOddNums
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter integer numbers on a single line separated by comma (,)");
            var sequenceOfNumbers = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var numbersThatOccurEvenNumberOfTimes = sequenceOfNumbers.GroupBy(x => x).Where(x => x.Count() % 2 == 0).ToList();

            Console.Write("The numbers that occur odd number of times are: ");
            foreach (var group in numbersThatOccurEvenNumberOfTimes)
            {
                foreach (var g in group)
                {
                    Console.Write("-{0}-",g);
                }
            }

            Console.WriteLine();
        }
    }
}
