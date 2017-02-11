namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class DivisibleBy7And3
    {
        public static void Main()
        {
            var arrayOfInts = new int[] { 11, 221, 13, 63, 4, 51, 160, 3457, 233, 14, 414, 3784352, 34002, 4321, 87240 };

            var divisableExtMeth = arrayOfInts.Where(n => n % 3 == 0 && n % 7 == 0).ToList();

            Console.WriteLine("Lambda expression:");
            Console.WriteLine("Numbers that are divisable by 7 and 3:");

            foreach (var item in divisableExtMeth)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 50));
            Console.WriteLine();
            var divisableLinq =
                from n in arrayOfInts
                where (n % 3 == 0 && n % 7 == 0)
                select n;

            Console.WriteLine("LINQ:");
            Console.WriteLine("Numbers, divisible by 3 and 7 \n{0}", string.Join(", ", divisableLinq));
        }
    }
}
