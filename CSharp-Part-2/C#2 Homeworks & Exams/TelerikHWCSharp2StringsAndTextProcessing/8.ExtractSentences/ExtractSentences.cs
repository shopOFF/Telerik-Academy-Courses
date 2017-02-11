using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractSentences
{
    static void Main()
    {
        // TODO: дава 30 точки само 
        string wordToSearchFor = Console.ReadLine();
        wordToSearchFor = String.Format(" " + wordToSearchFor + " ");
        string[] text = Console.ReadLine().Split(new char[] {'.'},StringSplitOptions.RemoveEmptyEntries).ToArray();

        StringBuilder newSentences = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains(wordToSearchFor))
            {
                newSentences.Append(text[i] + ".");
            }
        }
        Console.WriteLine(newSentences.ToString());
    }
}
// re6enie za 100 to4ki:

//using System;
//using System.Linq;
//using System.Text;

//public class ExtractSentences
//{
//    public static void Main(string[] args)
//    {
//        var word = Console.ReadLine();
//        var text = Console.ReadLine();
//        Console.WriteLine(ExtratSentencesFromText(text, word));
//    }

//    private static string ExtratSentencesFromText(string text, string wordToFind)
//    {
//        var extractedText = new StringBuilder();

//        var allSentense = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
//            .Select(x => x.Trim())
//            .ToArray();
//        for (int i = 0; i < allSentense.Length; i++)
//        {
//            if (FindWordInSentance(allSentense[i], wordToFind))
//            {
//                extractedText.Append(allSentense[i]);
//                extractedText.Append('.');

//                if (i < allSentense.Length)
//                {
//                    extractedText.Append(" ");
//                }
//            }
//        }

//        return extractedText.ToString().Trim();
//    }

//    private static bool FindWordInSentance(string sentance, string word)
//    {
//        bool isFind = false;
//        var nextIndexOfWord = sentance.IndexOf(word);

//        var lastIndex = sentance.Length - word.Length;

//        while (nextIndexOfWord > -1)
//        {
//            if (nextIndexOfWord != 0 &&
//              ((char.IsLetter(sentance[nextIndexOfWord - 1])) ||
//               (sentance[nextIndexOfWord - 1] == '-')))
//            {
//                nextIndexOfWord = sentance.IndexOf(word, nextIndexOfWord + 1);
//            }
//            else if (nextIndexOfWord < lastIndex &&
//                ((char.IsLetter(sentance[nextIndexOfWord + word.Length]) ||
//                (sentance[nextIndexOfWord + word.Length] == '-'))))
//            {
//                nextIndexOfWord = sentance.IndexOf(word, nextIndexOfWord + 1);
//            }
//            else
//            {
//                isFind = true;
//                break;
//            }
//        }

//        return isFind;
//    }
//}
//  re6enie za 90 to4ki 

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _08.ExtractSentences
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // TODO : 90/100 fix
//            string wordToSearch = Console.ReadLine().ToLower();
//            string input = Console.ReadLine();

//            Console.WriteLine(Extract(input, wordToSearch));
//        }

//        public static string Extract(string str, string keyword)
//        {
//            string[] arr = str.Split('.');
//            StringBuilder answer = new StringBuilder();
//            char[] separators = GetSeparators(str);
//            foreach (string sentence in from sentence in arr let words = sentence.ToLower().Split(separators).ToArray() let isMatch = words.Any(x => x == keyword) where isMatch select sentence)
//            {
//                answer.Append(sentence + ".");
//            }

//            return answer.ToString();
//        }

//        private static char[] GetSeparators(string text)
//        {
//            return text.Where(x => !char.IsLetter(x) && x != '.').Distinct().ToArray();
//        }
//    }
//}