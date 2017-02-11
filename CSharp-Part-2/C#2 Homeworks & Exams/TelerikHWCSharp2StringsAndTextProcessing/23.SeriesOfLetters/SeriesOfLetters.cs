using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SeriesOfLetters
{
    static string ReplacingAllSeriesOfConsecutiveIdenticalLetters(string input)
    {
        StringBuilder output = new StringBuilder();
        char currentLetter = '0';
        char lastLetter = '0';

        for (int i = 0; i < input.Length; i++)
        {
            currentLetter = input[i];
            if (currentLetter != lastLetter)
            {
                lastLetter = currentLetter;
                output.Append(lastLetter);
            }
        }

        return output.ToString();
    }
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ReplacingAllSeriesOfConsecutiveIdenticalLetters(input));
    }
}