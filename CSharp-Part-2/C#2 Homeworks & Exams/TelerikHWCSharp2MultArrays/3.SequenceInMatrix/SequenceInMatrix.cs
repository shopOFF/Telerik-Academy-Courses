using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');

        int n = int.Parse(nums[0]);
        int m = int.Parse(nums[1]);
        int currentSequence = 1;
        int longestSequence = 1;
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < input.Length; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        // on the same row
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSequence++;
                }
                if (longestSequence < currentSequence)
                {
                    longestSequence = currentSequence;
                }
                if (matrix[row, col] != matrix[row, col + 1])
                {
                    currentSequence = 1;
                }
            }
        }

        // on the same col
        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence++;
                }
                if (longestSequence < currentSequence)
                {
                    longestSequence = currentSequence;
                }
                if (matrix[row, col] != matrix[row + 1, col])
                {
                    currentSequence = 1;
                }
            }
        }
        currentSequence = 1;
        // on the same diagonal        pod vapros 
        for (int i = 0; i < m - 2; i++)
        //{
        //    if (matrix[i, i] == matrix[i + 1, i + 1])
        //    {
        //        currentSequence++;
        //    }
        //    if (longestSequence < currentSequence)
        //    {
        //        longestSequence = currentSequence;
        //    }
        //    if (matrix[i, i] != matrix[i + 1, i + 1])
        //    {
        //        currentSequence = 1;
        //    }
        //}
        Console.WriteLine(longestSequence);
    }
}


