using System;

namespace _01.NNestedLoops
{
    public class Program
    {
        private static int[] array;
        private static int n;
        private static int k;

        public static void NestetLoopsWhitRecursion(int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", array));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    array[index] = i + 1;
                    Console.WriteLine("Kopaem nadolo {0}",i);
                    NestetLoopsWhitRecursion(index + 1);
                    Console.WriteLine("Vra6tame se nagore {0}",i);
                }
            }
        }

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            k = n;
            array = new int[k];
            NestetLoopsWhitRecursion(0);
        }
    }
}
