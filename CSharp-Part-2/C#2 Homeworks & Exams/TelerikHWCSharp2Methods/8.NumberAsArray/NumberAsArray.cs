using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NumberAsArray
{
    static string addingArrays(string[] firstArray, string[] secondArray)
    {
        string revResult = "";
        string result = "";
        string first = string.Join("",firstArray);
        string second = string.Join("", secondArray);

        BigInteger firstIntArr = BigInteger.Parse(first);
        BigInteger secondIntArr = BigInteger.Parse(second);

        BigInteger reversedResult = firstIntArr + secondIntArr;
        revResult = Convert.ToString(reversedResult);

        for (int i = revResult.Length - 1; i >= 0; i--)
        {
            if (i>0)
            {
                result += revResult[i] + " ";
            }
            else
            {
                result += revResult[i];
            }
        }
        return result;
    }
    static void Main()
    {
        string arrLengths = Console.ReadLine();
        //int firsArrLenth = int.Parse(arrLengths[0]);
        //int secondArrLenth = int.Parse(arrLengths[1]);  nqma da ni trqbvat tezi 2 reda
        string[] firstLine = Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');
        Array.Reverse(firstLine);
        Array.Reverse(secondLine);

        Console.WriteLine(addingArrays(firstLine, secondLine));
    }
}