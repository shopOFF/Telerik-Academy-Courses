using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumIntegers
{
    static int CalculatingSumOfNums(int[] nums)
    {
        int sum = nums.Sum();
        return sum;
    }
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(CalculatingSumOfNums(nums));
    }
}