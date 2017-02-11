using System;
using System.Linq;
using System.Numerics;

class Solution
{
    static string EncodeHint(string hint)
    {
        var symbols = hint.Select(x =>
        {
            var code = (int)x;
            var encoded = "";

            do
            {
                encoded = (code % 6) + encoded;
                code /= 6;
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
            var asciiDecimalCode = number % 10 + (number / 10 % 10) * 6 + (number / 100 % 10) * 36;
            hint += (char)asciiDecimalCode;
        }

        Console.WriteLine(hint);
    }

    static void Main()
    {
        var numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
        var product = new BigInteger(1);

        foreach(var functionalNumber in numbers)
        {
            var hexNumber = functionalNumber
                                .Replace("commonlisp", "D")
                                .Replace("standardml", "9")
                                .Replace("haskell", "1")
                                .Replace("mercury", "C")
                                .Replace("clojure", "7")
                                .Replace("erlang", "8")
                                .Replace("scheme", "E")
                                .Replace("racket", "A")
                                .Replace("curry", "F")
                                .Replace("ocaml", "0")
                                .Replace("scala", "2")
                                .Replace("lisp", "4")
                                .Replace("rust", "5")
                                .Replace("elm", "B")
                                .Replace("ml", "6")
                                .Replace("f#", "3");

                product *= new BigInteger(Convert.ToInt64(hexNumber, 16));
        }

        Console.WriteLine(product);
    }
}