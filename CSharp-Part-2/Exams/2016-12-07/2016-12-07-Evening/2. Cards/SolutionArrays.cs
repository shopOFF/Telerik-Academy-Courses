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
            // loop can be used instead of reverse
            var hand = string.Join("", Convert.ToString(long.Parse(Console.ReadLine()), 2).Reverse());

            for(var i = 0; i < hand.Length; i++)
            {
                cards[i] += (hand[i] - '0');
            }
        }

        // loop can be used instead of count
        var hasFullDeck = cards.Count(x => x > 0) == cards.Length;

        Console.WriteLine(hasFullDeck ? "Full deck" : "Wa wa!");

        for(var i = 0; i < cards.Length; i++)
        {
            if(cards[i] % 2 == 1)
            {
                var typeIndex = i % types.Length;
                var suitIndex = i / types.Length;

                Console.Write(types[typeIndex] + "" + suits[suitIndex] + " ");
            }
        }
    }
}