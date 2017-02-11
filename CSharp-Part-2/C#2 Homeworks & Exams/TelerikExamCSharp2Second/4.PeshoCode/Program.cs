using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var wordToFind = Console.ReadLine();
        var numberOfLines = int.Parse(Console.ReadLine());
        var text = new StringBuilder();
        var result = 0;

        for (int i = 0; i < numberOfLines; i++)
        {
            text.Append(Console.ReadLine());
        }

        var splitedText = Regex.Split(text.ToString(), @"(?<=[.?])");
        //var some=text.ToString().Split(new string[] { "? ",". " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        foreach (var sent in splitedText)
        {
            if (sent.Contains(wordToFind))
            {
                var wordToFindIndex = sent.IndexOf(wordToFind);
                var slicedSentance = string.Empty;
                var trimedAndUppercaseSent = string.Empty;

                if (sent.Contains("?"))
                {
                    slicedSentance = sent.Substring(wordToFindIndex + (wordToFind.Length));
                    trimedAndUppercaseSent = slicedSentance.Trim(new Char[] { '?' }).Replace(" ", string.Empty).ToUpper();       
                }
                else
                {
                    slicedSentance = sent.Substring(0, wordToFindIndex);
                    trimedAndUppercaseSent = slicedSentance.Replace(" ", string.Empty).ToUpper();
                }

                foreach (var item in trimedAndUppercaseSent)
                {
                    result += (char)item;
                }

                Console.WriteLine(result);
                break;
            }
        }
    }
}

