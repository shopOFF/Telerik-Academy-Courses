using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MovingLetters
{
    // re6enie za 60 to4ki, za po dobro re6enieto na Kenov na zapis!

    static string LetterShuffler(string lastLetters)
    {
        List<char> lettersInArray = lastLetters.ToList();
        char item = ' ';
        int letterNumber = 0;
        int letterNewIndex = 0;
        for (int i = 0; i < lastLetters.Length; i++)
        {
            if (char.IsLower(lettersInArray[i]))
            {
                letterNumber = lettersInArray[i] - 'a' + 1;
            }
            else
            {
                letterNumber = lettersInArray[i] - 'A' + 1;
            }
            // ot tuk zapo4va vajnata 4ast
            letterNewIndex = (letterNumber + i) % lastLetters.Length;   // taka se vzima poziciqta( indexa)+i(momentnata poziciq na koqto sme v teksta i ot koqto zapo4vame da broim !!!) s procentno delenie(celo4isleno) 

            item = lettersInArray[i];
            lettersInArray[i] = '-';    // ili ravno na null vmesto '-' ili direektno si mahame ne6toto na taazi poziciq s RemoveAt(i)!!!
            lettersInArray.Remove('-');
            lettersInArray.Insert(letterNewIndex, item);

        }
        return string.Join("", lettersInArray);
    }
    static string LastLettersSwaper(int longestLength, string[] words)
    {
        StringBuilder lastLetters = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = (words[i].PadLeft(longestLength, ' '));
        }
        for (int i = longestLength - 1; i >= 0; i--)
        {
            lastLetters.Append(new string(words.Select(s => s[i]).ToArray()));
        }

        return LetterShuffler(lastLetters.ToString().Replace(" ", ""));
    }
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' });  // no s masivi e dosta bavno moje s druga kolekcia da se optimizira
        int longestLength = words.Max(w => w.Length);

        Console.WriteLine(LastLettersSwaper(longestLength, words));
    }
}