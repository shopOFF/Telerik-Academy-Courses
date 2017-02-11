using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        const string types = "23456789TJQKA";
        const string suits = "cdhs";

        var n = int.Parse(Console.ReadLine());
        var cards = new int[52];

        while(n-- > 0)
        {
            // the solution doesn't require built-in methods like .Reverse(), same can be achievev using loops
            var hand = string.Join("", Convert.ToString(long.Parse(Console.ReadLine()), 2).Reverse());

            for(var i = 0; i < hand.Length; i++)
            {
                cards[i] += (hand[i] - '0');
            }
        }

        // instead of for loop that counts
        var hasFullDeck = cards.Count(x => x > 0) == cards.Length;

        Console.WriteLine(hasFullDeck ? "Full deck" : "Wa wa!");

        for(var i = 0; i < cards.Length; i++)
        {
            if(cards[i] % 2 == 0)
            {
                var typeIndex = i % types.Length;
                var suitIndex = i / types.Length;

                Console.Write(types[typeIndex] + "" + suits[suitIndex] + " ");
            }
        }
    }
}