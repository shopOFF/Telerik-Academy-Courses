using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
{
    static int checkArrayElemnts(int[] numsInIntArray)
    {
        int largerElemntsCounter = 0;
        for (int i = 1; i < numsInIntArray.Length; i++)
        {
            if (i > 0 && i < numsInIntArray.Length - 1)
            {
                if (numsInIntArray[i] > numsInIntArray[i - 1] && numsInIntArray[i] > numsInIntArray[i + 1])
                {
                    largerElemntsCounter++;
                }
            }
        }
        return largerElemntsCounter;
    }
    static void Main()
    {
        int arrlength = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');
        int[] numsInIntArray = Array.ConvertAll(nums, int.Parse);

        Console.WriteLine(checkArrayElemnts(numsInIntArray));
    }
}