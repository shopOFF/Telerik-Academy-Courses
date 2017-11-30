using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.PeshoCode
{
    public class Program
    {
        public static void CalculateSum(char punctMark, List<string> sent,string wordToFind,int sentenceBeforeOrAfterWord,int loopIndex)
        {
            var selectedSentence = sent[loopIndex].Split(new string[] { wordToFind }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var correctSentencePartToUpper = selectedSentence[sentenceBeforeOrAfterWord].ToUpper();
            var sum = 0;

            foreach (var letter in correctSentencePartToUpper)
            {
                if (letter == ' ' || letter == punctMark)
                {

                }
                else
                {
                    sum += Convert.ToInt32(letter);
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            var wordToFind = Console.ReadLine();
            var numberOfRows = Convert.ToInt32(Console.ReadLine());

            var sentence = new StringBuilder();

            for (int i = 0; i < numberOfRows; i++)
            {
                sentence.Append(Console.ReadLine());
            }

            string pattern = "(?<=[.?])";
            var sent = Regex.Split(sentence.ToString(), pattern).ToList();

            for (int i = 0; i < sent.Count(); i++)
            {
                
                if (sent[i].Contains(wordToFind) && sent[i].Contains("?"))
                {
                    CalculateSum('?', sent, wordToFind, 1, i);
                }
                if (sent[i].Contains(wordToFind) && sent[i].Contains("."))
                {
                    CalculateSum('.', sent, wordToFind, 0, i);
                }
            }

        }
    }
}
