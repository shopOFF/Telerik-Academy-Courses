using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareArrays
{
    static void Main()
    {
        int arrLength = int.Parse(Console.ReadLine());

        int[] arr1 = new int[arrLength];
        int[] arr2 = new int[arrLength];
        bool isEqual = false;

        for (int i = 0; i < arrLength; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrLength; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrLength; i++)
        {
            if (arr1[i] == arr2[i])
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
                break;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}

