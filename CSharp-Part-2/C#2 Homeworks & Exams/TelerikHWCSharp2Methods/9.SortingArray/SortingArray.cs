using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
{
    static void SortingArrays(int[] nums)
    {
        Array.Sort(nums);
        Console.WriteLine(string.Join(" ",nums));
    }
    static void Main()
    {
        Console.ReadLine();
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  // direktno pro4ita maha praznite speisove i konvertira kam int i gi slaga v masiva
        SortingArrays(nums);
    }
}