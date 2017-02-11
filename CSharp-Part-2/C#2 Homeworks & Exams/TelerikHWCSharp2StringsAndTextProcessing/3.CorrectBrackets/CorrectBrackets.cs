using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static string CheckForCorrectlyPutBrackets(string text)
    {
        int openingBrackets = 0;
        int closingBrackets = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(')
            {
                openingBrackets++;
            }
            if(text[i]==')')
            {
                closingBrackets++;
            }
        }
        if (text.IndexOf('(') < text.IndexOf(')') && openingBrackets == closingBrackets)
        {
            return "Correct";
        }
        else
        {
            return "Incorrect";
        }
    }
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(CheckForCorrectlyPutBrackets(text));
    }
}