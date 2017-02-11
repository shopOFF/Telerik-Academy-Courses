using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubStringInText
{
    static int CheckForSubStrings(string pattern, string text)
    {
        int index = 0;
        int occurrenceCounter = 0;

        while (true)
        {
            int found = text.IndexOf(pattern, index);
            if (found < 0)
            {
                break;
            }
            else
            {
                occurrenceCounter++;
                index = found + 1;
            }
        }
        return occurrenceCounter;
    }
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();   // dumi4kata koqto 6te tarsim v texta
        string text = Console.ReadLine().ToLower();      // samiqt text
        Console.WriteLine(CheckForSubStrings(pattern, text));
    }
}