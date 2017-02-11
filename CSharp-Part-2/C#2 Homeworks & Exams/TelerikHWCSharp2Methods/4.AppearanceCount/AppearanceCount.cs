using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppearanceCount
{
    static int CountHowManyTimeNumberAppearcs(int[] numsInArray, int numberToCheckFor)
    {
        int appearenceCounter = 0;
        foreach (var item in numsInArray)
        {
            if (item == numberToCheckFor)
            {
                appearenceCounter++;
            }
        }
        return appearenceCounter;
    }
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');
        int numberToCheckFor = int.Parse(Console.ReadLine());

        int[] numsInArray = Array.ConvertAll(nums, int.Parse);

        int numberOfAppearances = CountHowManyTimeNumberAppearcs(numsInArray, numberToCheckFor); // moje i direktno CountHowManyTimeNumberAppearcs(numsInArray, numberToCheckFor) c Console.WriteLine() da go slojim i gotovo
        Console.WriteLine(numberOfAppearances);
    }
}