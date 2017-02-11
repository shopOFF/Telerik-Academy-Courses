using System;
using System.Collections.Generic;

namespace Task9PrintFirst50Members
{
   public class StartUp
    {
        internal static Queue<int> SequenceCreator(int number)
        {
            int numberOfMembersToPrint = 50;

            var container = new Queue<int>();
            container.Enqueue(number);
            var result = new Queue<int>();

            for (int i = 0; i < numberOfMembersToPrint; i++)
            {
                int currentBase = container.Dequeue();
                result.Enqueue(currentBase);
                container.Enqueue(currentBase + 1);
                container.Enqueue(2 * currentBase + 1);
                container.Enqueue(currentBase + 2);
            }

            return result;
        }
       public static void Main()
        {
            Console.Write("Enter number N = ");
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}",string.Join(", ",SequenceCreator(input)));
        }
    }
}
