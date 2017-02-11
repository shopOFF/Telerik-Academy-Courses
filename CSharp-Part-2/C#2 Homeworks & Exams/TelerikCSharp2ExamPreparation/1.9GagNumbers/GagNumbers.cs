using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class GagNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> alphabet = new List<string>() { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        StringBuilder splitingTheInput = new StringBuilder();
        int numberIn9 = 0;
        BigInteger numberInDec = 0;

        for (int i = 0; i < input.Length; i++)
        {
            splitingTheInput.Append(input[i]);

            if (alphabet.Contains(splitingTheInput.ToString()))
            {
                numberIn9 = alphabet.IndexOf(splitingTheInput.ToString());
                splitingTheInput.Clear();

                numberInDec *= 9;
                numberInDec += numberIn9;
            }
        }
        Console.WriteLine(numberInDec);
    }
}