using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static string StringReversing(string text)
    {
        StringBuilder reversedText = new StringBuilder(text.Length);
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }
        return reversedText.ToString();
    }
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(StringReversing(text));   // ili prosto si polzvame metoda Array.Reverse() eto taka 
                                                    //char[] arr = s.ToCharArray();
                                                    //Array.Reverse(arr);
                                                    //Console.WriteLine(arr);
    }
}