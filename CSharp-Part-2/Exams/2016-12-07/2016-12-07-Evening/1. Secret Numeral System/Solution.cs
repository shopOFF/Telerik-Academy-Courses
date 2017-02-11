using System;
using System.Linq;
using System.Numerics;

class FunctionalNumeralSystem
{
    static string EncodeHint(string hint)
    {
        var symbols = hint.Select(x =>
        {
            var code = (int)x;
            var encoded = "";

            do
            {
                encoded = (code % 7) + encoded;
                code /= 7;
            } while (code > 0);

            return "\"" + encoded + "\"";
        });

        return string.Join(", ", symbols);
    }

    static void PrintHint(string[] hintSymbols)
    {
        var hint = "";

        foreach (var code in hintSymbols)
        {
            var number = int.Parse(code);
            var asciiDecimalCode = number % 10 + (number / 10 % 10) * 7 + (number / 100 % 10) * 49;
            hint += (char)asciiDecimalCode;
        }

        Console.WriteLine(hint);
    }

    static void Main()
    {
        var numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
        var product = new BigInteger(1);

        foreach (var functionalNumber in numbers)
        {
            var octNumberString = functionalNumber
                                        .Replace("haralampi", "5")
                                        .Replace("hristofor", "3")
                                        .Replace("vladimir", "7")
                                        .Replace("hristo", "0")
                                        .Replace("pesho", "2")
                                        .Replace("tosho", "1")
                                        .Replace("vlad", "4")
                                        .Replace("zoro", "6");

            product *= new BigInteger(Convert.ToInt64(octNumberString, 8));
        }

        Console.WriteLine(product);
    }
}