using System;
using System.Linq;

namespace Task8MajorantOfArray
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter integer numbers on a single line separated by comma (,)");
            var sequenceOfNumbers = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var numberThatHaveMostOccurences = sequenceOfNumbers
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .FirstOrDefault();

            bool isMajorantPresent = numberThatHaveMostOccurences.Count() >= (sequenceOfNumbers.Count() / 2) + 1;

            if (isMajorantPresent)
            {
                Console.WriteLine("The majorant in the array is: {0}", numberThatHaveMostOccurences.Key);
            }
            else
            {
                Console.WriteLine("There is no majorant in the array!");
            }
        }
    }
}
