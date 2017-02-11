using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddingPolynomials
{
    static void PolynomialsAdding(int[] first, int[] second)
    {
        int[] sumOfArrays = new int[first.Length];
        for (int i = 0; i < first.Length; i++)
        {
            sumOfArrays[i] = first[i] + second[i];
        }
        Console.WriteLine(string.Join(" ", sumOfArrays));
    }
    static void Main()
    {
        Console.ReadLine();
        int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        PolynomialsAdding(firstArray, secondArray); 
    }
}