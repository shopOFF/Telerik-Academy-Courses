using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerCalculations
{
    static int SmallestNumber(int[] numbers)
    {
        int smallestNum = numbers.Min();
        return smallestNum;
    }
    static int BiggestNumber(int[] numbers)
    {
        int biggestNum = numbers.Max();
        return biggestNum;
    }
    static double CalculatingAvarage(int[] numbers)
    {
        double avarage = numbers.Average();
        return avarage;
    }
    static int CalculatingSum(int[] numbers)
    {
        int sum = numbers.Sum();
        return sum;
    }
    static long CalculatingProduct(int[] numbers)
    {
        long product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(SmallestNumber(numbers));
        Console.WriteLine(BiggestNumber(numbers));
        Console.WriteLine("{0:F2}", CalculatingAvarage(numbers));
        Console.WriteLine(CalculatingSum(numbers));
        Console.WriteLine(CalculatingProduct(numbers));
    }
}