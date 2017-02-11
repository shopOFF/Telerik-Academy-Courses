using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int maxSequenceCounter = 1;
        int currentSequenceCounter = 1;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentSequenceCounter++;

                if (currentSequenceCounter >= maxSequenceCounter)
                {
                    maxSequenceCounter = currentSequenceCounter;
                }
            }
            else if (array[i] != array[i + 1])
            {
                currentSequenceCounter = 1;
            }
        }
        Console.WriteLine(maxSequenceCounter);
    }
}