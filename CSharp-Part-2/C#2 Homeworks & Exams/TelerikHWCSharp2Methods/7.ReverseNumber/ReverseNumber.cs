using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseNumber
{
    static string ReversingNumber(decimal num)
    {
        string decimalToString = Convert.ToString(num);
        string reversedNumber = "";
        for (int i = decimalToString.Length - 1; i >= 0; i--)
        {
            reversedNumber += decimalToString[i];
        }
        return reversedNumber;
    }
    static void Main()
    {
        decimal num = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReversingNumber(num));
    }
}
