using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5RemoveAllNegativeNums
{
    public class StartUp
    {
        internal static List<int> FindLongestSubsequence(List<int> sequence)
        {
            List<int> result = new List<int>();

            int currentCount = 1;
            int bestNumber = 0;
            int bestCount = 1;

            for (int index = 0; index < sequence.Count - 1; index++)
            {
                if (sequence[index] == sequence[index + 1])
                {
                    currentCount++;

                    if (index == sequence.Count - 2)
                    {
                        if (currentCount > bestCount)
                        {
                            bestCount = currentCount;
                            bestNumber = sequence[index];
                        }
                    }
                }
                else
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestNumber = sequence[index];
                    }

                    currentCount = 1;
                }
            }

            for (int index = 0; index < bestCount; index++)
                result.Add(bestNumber);

            return result;
        }

        public static void Main()
        {
            Console.WriteLine("Enter integer numbers on a single line separated by comma (,)");
            var sequenceOfNumbers = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var sequenceOfPositiveNumbers = sequenceOfNumbers.Where(n => n > 0).ToList();
            var longestSubsequence = FindLongestSubsequence(sequenceOfPositiveNumbers);

            Console.WriteLine("The sequence of numbers is: {0}", string.Join(", ", sequenceOfNumbers));
            Console.WriteLine("The sequence of positive numbers is: {0}", string.Join(", ", sequenceOfPositiveNumbers));

            Console.WriteLine("The longest subsequence of positive numbers is: {0}", string.Join(", ", longestSubsequence));
        }
    }
}
