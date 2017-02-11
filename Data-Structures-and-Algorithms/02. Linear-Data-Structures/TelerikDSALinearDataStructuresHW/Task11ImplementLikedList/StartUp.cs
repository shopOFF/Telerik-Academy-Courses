using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11ImplementLikedList
{
    public class StartUp
    {
        public static void Main()
        {
            var someLinkedList = new MyLinkedList<int>();

            someLinkedList.Add(50);
            someLinkedList.Add(5);
            someLinkedList.Add(25);

            int counter = 1;
            foreach (var item in someLinkedList)
            {
                Console.WriteLine("{0}. Value is {1}", counter, item);
                counter++;
            }
        }
    }
}
