using System;
using System.Text;

namespace _03.Combinations
{
    public class Program
    {
        private static int n;
        private static int k;
        private static int[] arr;
        private static StringBuilder sb;

        private static void GenerateCombinations(int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                int p = index > 0 ? arr[index - 1] : 0;
                for (int i = p; i < n; i++)
                {
                    arr[index] = i + 1;
                    GenerateCombinations(index + 1);
                }
            }
        }
        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            arr = new int[k];
            sb = new StringBuilder();

            GenerateCombinations(0);
        }
    }
}
