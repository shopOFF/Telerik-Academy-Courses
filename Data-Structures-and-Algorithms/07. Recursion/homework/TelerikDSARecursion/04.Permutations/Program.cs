using System;
using System.Linq;

namespace _04.Permutations
{
    public class Program
    {
        private static int n;
        private static int[] arr;

        private static void GeneratePermutations(int index)
        {
            if (index >= n)
            {
                if (arr.Distinct().Count() == n)
                {
                    Console.WriteLine(string.Join(", ", arr.Distinct()));
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    GeneratePermutations(index + 1);
                }
            }
        }

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            arr = new int[n];

            GeneratePermutations(0);
        }
    }
}
