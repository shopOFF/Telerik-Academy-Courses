using System;
using System.Text;

namespace _02.CombinationsWithDuplicat
{
    public class Program
    {
        private static int n;
        private static int k;
        private static int[] array;
        private static StringBuilder sb;

        private static void Generate(int index, int start)
        {
            if (index >= k)
            {
                sb.Append("(");
                sb.Append(string.Join(" ", array));
                sb.Append("), ");
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    array[index] = i + 1;
                    Generate(index + 1, i);
                }
            }
        }

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            sb = new StringBuilder();
            array = new int[k];
            Generate(0, 0);

            Console.WriteLine(sb.ToString().Trim(new char[] { ',', ' ' }));
        }
    }
}
