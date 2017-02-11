using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13ImplementADTQueue
{
    public class StartUp
    {
        public static void Main()
        {
            var testQueue = new MyQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                testQueue.Enqueue((i + 1) * 10);
            }

            Console.WriteLine("You have {0} elements in the queue", testQueue.Count);

            int size = testQueue.Count;
            for (int i = 0; i < size; i++)
            {
                var firstElemnet = testQueue.Dequeue();
                Console.WriteLine("Removing the element at the begining {0}", firstElemnet);
            }

            Console.WriteLine("You have {0} elements in the queue", testQueue.Count);
        }
    }
}
