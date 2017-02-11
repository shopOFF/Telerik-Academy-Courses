using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EvenDifferences
{    // metod za namirane na absoliutnata razlika mejdu 2 4isla(maximalnata razlika mejdu tqh)
    static long FindDifference(long nr1, long nr2)
    {
        return Math.Abs(nr1 - nr2);
    }
    // metoda koito iz4islqva koi to4no 4isla da iz4islqva
    static long AbsoluteDifferenceOfNumbers(long[] numbers)
    {
        List<long> absoluteDifferences = new List<long>();
        int arrayCounter = 0;
        long sumOfEvenAbsolutes = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (i == 1 || absoluteDifferences[arrayCounter - 1] % 2 != 0)
            {
                absoluteDifferences.Add(FindDifference(numbers[i], numbers[i - 1]));
            }
            else
            {
                absoluteDifferences.Add(FindDifference(numbers[i + 1], numbers[i]));
                i++;
            }
            arrayCounter++;
            if (absoluteDifferences[arrayCounter - 1] % 2 == 0 && i == (numbers.Length - 2))
            {
                break;
            }
        }
        // checking and suming odd absolutes
        for (int i = 0; i < absoluteDifferences.Count; i++)
        {
            if (absoluteDifferences[i] % 2 == 0)
            {
                sumOfEvenAbsolutes += absoluteDifferences[i];
            }
        }
        return sumOfEvenAbsolutes;
    }
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        Console.WriteLine(AbsoluteDifferenceOfNumbers(numbers));
    }
}

// otdelen algoritam za namirane na absoliutnata stoinost na 2 4isla
//int result = number1 - number2;
//if (result < 0) {
//    result *= -1;
//}