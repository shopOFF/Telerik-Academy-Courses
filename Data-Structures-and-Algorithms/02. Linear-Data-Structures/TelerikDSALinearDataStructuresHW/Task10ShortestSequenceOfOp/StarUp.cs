using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10ShortestSequenceOfOp
{
    public class StarUp
    {
        private static void PrintShortestSequence(int start, int target)
        {
            if (start < 0 || start >= target)
            {
                Console.WriteLine("Start should be >= 0 and smaller than the target!");
                return;
            }

            var sequence = new Queue<int>();
            sequence.Enqueue(start);

            if (start + 1 == target)
            {
                sequence.Enqueue(start + 1);
                Console.WriteLine(string.Join(" --> ", sequence));
                return;
            }

            if (start + 2 == target)
            {
                sequence.Enqueue(start + 2);
                Console.WriteLine(string.Join(" --> ", sequence));
                return;
            }

            if (start + 2 > start * 2)
            {
                start += 2;
                sequence.Enqueue(start);
            }

            if (start * 2 > target)
            {
                while (start + 2 <= target)
                {
                    sequence.Enqueue(start += 2);
                }

                if (start != target)
                {
                    sequence.Enqueue(start += 1);
                }

                Console.WriteLine(string.Join(" --> ", sequence));
                return;
            }

            while (start * 2 < target / 2)
            {
                sequence.Enqueue(start *= 2);
            }

            while (start + 2 <= target / 2)
            {
                sequence.Enqueue(start += 2);
            }

            while (start + 1 <= target / 2)
            {
                sequence.Enqueue(start += 1);
            }

            sequence.Enqueue(start *= 2);

            if (start != target)
            {
                sequence.Enqueue(start += 1);
            }

            Console.WriteLine(string.Join(" --> ", sequence));
        }

        public static void Main()
        {
            PrintShortestSequence(5, 16);
        }
    }
}
