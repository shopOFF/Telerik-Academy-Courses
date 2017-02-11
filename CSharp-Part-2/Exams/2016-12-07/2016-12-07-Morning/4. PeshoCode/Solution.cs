using System;
using System.Collections.Generic;
using System.Numerics;

namespace Solution
{
    public class Program
    { 
        public static void Main()
        {
            var word = Console.ReadLine();
            var linesCount = int.Parse(Console.ReadLine());
            var lines = new List<string>();

            for (int line = 0; line < linesCount; line++)
            {
                lines.Add(Console.ReadLine());
            }

            var text = string.Join(" ", lines);

            var wordIndex = text.IndexOf(word);
            var sentanceBegining = -1;
            var sentanceEnd = -1;

            for (int index = wordIndex; index > 0; index--)
            {
                if (text[index] >= 65 && text[index] <= 90)
                {
                    sentanceBegining = index;
                    break;
                }
            }
            
            string targetSubstring = string.Empty;

            for (int index = wordIndex + word.Length; index < text.Length; index++)
            {
                if (text[index] == '.')
                {
                    sentanceEnd = index;
                    targetSubstring = text.Substring(sentanceBegining, wordIndex - sentanceBegining);
                    break;
                }

                if (text[index] == '?')
                {
                    sentanceEnd = index;
                    targetSubstring = text.Substring(wordIndex + word.Length, sentanceEnd - (wordIndex + word.Length));
                    break;
                }
            }

            
            var gluedSubstring = targetSubstring.Replace(" ", string.Empty).ToUpper();
            BigInteger result = 0;

            foreach (var character in gluedSubstring)
            {
                result += character;
            }
            
            Console.WriteLine(result);
        }
    }
}
