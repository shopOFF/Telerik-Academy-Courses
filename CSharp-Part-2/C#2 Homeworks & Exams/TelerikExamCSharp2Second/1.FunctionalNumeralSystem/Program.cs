using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Messages
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        List<string> alphabet = new List<string>() { "ocaml", "haskell", "scala", "f#", "lisp", "rust", "ml", "clojure", "erlang", "standardml", "racket", "elm", "mercury", "commonlisp", "scheme", "curry" };
        StringBuilder splitingTheInput = new StringBuilder();
        var numberInIkuc = 0;
        BigInteger numberInDec = 0;
        var arr = new List<BigInteger>();
        BigInteger finalResult = 1;

        foreach (var num in input)
        {
            for (int i = 0; i < num.Length; i++)
            {
                splitingTheInput.Append(num[i]);

                if (alphabet.Contains(splitingTheInput.ToString()))
                {
                    numberInIkuc = alphabet.IndexOf(splitingTheInput.ToString());
                    splitingTheInput.Clear();

                    numberInDec *= 16;
                    numberInDec += numberInIkuc;

                }
            }

            arr.Add(numberInDec);
            numberInDec = 0;
        }

        foreach (var item in arr)
        {
            finalResult *= item;
        }

        Console.WriteLine(finalResult);
    }
}