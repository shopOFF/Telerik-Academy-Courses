using System;
using System.Linq;

namespace Task7OccurenceInArray
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter integer numbers on a single line separated by comma (,)");
            var sequenceOfNumbers = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var numbersAndOccurenceTimes = sequenceOfNumbers
                .GroupBy(x => x)
                .OrderBy(x => x.Key);

            Console.WriteLine("The numbers that occurs and how many times it occurs: ");

            foreach (var group in numbersAndOccurenceTimes)
            {
                Console.WriteLine("{0} -> {1} times", group.Key, group.Count());
            }
        }
    }
}
