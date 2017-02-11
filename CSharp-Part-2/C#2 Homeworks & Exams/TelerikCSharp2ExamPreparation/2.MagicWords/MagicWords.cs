using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicWords
{
    static string LetterSwap(int n, List<string> words)
    {
        List<string> switchedWords = new List<string>(n);
        StringBuilder letterSwitch = new StringBuilder();
        string moveItem = string.Empty;
        for (int i = 0; i < n ; i++)
        {
            for (int j = 0; j < 1; j++)
            {
                moveItem = words[i];
                words[i] = null;
                words.Insert((moveItem.Length % (n + 1)), moveItem);
                words.Remove(null);
            }
        }
        int longestLength = words.Max(w => w.Length);
        for (int i = 0; i < words.Count; i++)
        {
            switchedWords.Add(words[i].PadRight(longestLength, ' '));
        }

        for (int i = 0; i < longestLength; i++)
        {
            letterSwitch.Append(new string(switchedWords.Select(s => s[i]).ToArray()));
        }

        return letterSwitch.ToString().Replace(" ", "");
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = string.Empty;
        List<string> words = new List<string>(n);

        for (int i = 0; i < n; i++)
        {
            word = Console.ReadLine();
            words.Add(word);
        }
        Console.WriteLine(LetterSwap(n, words));
    }
}