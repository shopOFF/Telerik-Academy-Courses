using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var digits = new List<string>() { "ocaml", "haskell", "scala", "f#", "lisp", "rust", "ml", "clojure", "erlang", "standardml", "racket", "elm", "mercury", "commonlisp", "scheme", "curry" };

            StringBuilder splitingTheInput = new StringBuilder();
            var numberInFunctionalNumeralSystem = 0;
            BigInteger numberInDec = 0;
            var arr = new List<BigInteger>();

            foreach (var num in input)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    splitingTheInput.Append(num[i]);

                    if (digits.Contains(splitingTheInput.ToString()))
                    {
                        numberInFunctionalNumeralSystem = digits.IndexOf(splitingTheInput.ToString());
                        splitingTheInput.Clear();

                        numberInDec *= 16;
                        numberInDec += numberInFunctionalNumeralSystem;
                    }
                }

                arr.Add(numberInDec);
                numberInDec = 0;
            }

            BigInteger finalResult = 1;

            foreach (var item in arr)
            {
                finalResult *= item;
            }

            Console.WriteLine(finalResult);
        }
    }
}
