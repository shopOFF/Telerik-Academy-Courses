using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        var maxSum = int.MinValue;
        var currSum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            currSum += arr[i];

            if (currSum > maxSum)
            {
                maxSum = currSum;
            }

            if (currSum < 0)
            {
                currSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}