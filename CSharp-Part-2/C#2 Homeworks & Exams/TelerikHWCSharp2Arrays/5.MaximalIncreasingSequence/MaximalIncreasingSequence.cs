using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        int incCounter = 0;
        string maxIncSequenceCounter = "";
        string currentIncSequenceCounter = "";

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {

            if (array[i] < array[i + 1])
            {
                currentIncSequenceCounter += array[i];
            }
            else if (incCounter >= 1 && array[i] > array[i - 1])
            {
                currentIncSequenceCounter += array[i];
            }
            else
            {
                currentIncSequenceCounter = "";
            }
            if (currentIncSequenceCounter.Length > maxIncSequenceCounter.Length)
            {
                maxIncSequenceCounter = currentIncSequenceCounter;
            }
            incCounter++;
        }
        Console.WriteLine(maxIncSequenceCounter.Length);
    }
}
// re6enie za 100 to4ki mn dobro
//using System;

//class MaxIncreasingFrom1stElSequence
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int maxLength = 1;
//        int firstElement = array[0];
//        int counter = 1;

//        for (int i = 1; i < n; i++)
//        {
//            if (array[i] > firstElement)
//            {
//                counter++;
//            }
//            else
//            {
//                if (counter > maxLength)
//                {
//                    maxLength = counter;
//                }

//                firstElement = array[i];
//                counter = 1;
//            }
//        }
//        if (counter > maxLength)
//        {
//            maxLength = counter;
//        }
//        Console.WriteLine(maxLength);
//    }
//}
