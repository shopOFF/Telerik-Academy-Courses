using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        int indexOfLetter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            indexOfLetter = text[i] - 'a';
            Console.WriteLine(indexOfLetter);
        }
    }
}