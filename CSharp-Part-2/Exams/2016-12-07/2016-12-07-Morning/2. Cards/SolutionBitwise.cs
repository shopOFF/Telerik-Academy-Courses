usign System;

class Solution
{
    static void Solve()
    {
        const string types = "23456789TJQKA";
        const string suits = "cdhs";
        const long fullDeck = (1L << 52) - 1;

        var n = int.Parse(Console.ReadLine());

        long deck = 0;
        long parity = 0;

        while (n-- > 0)
        {
            var hand = long.Parse(Console.ReadLine());

            deck |= hand;
            parity ^= hand;
        }

        Console.WriteLine(deck == fullDeck ? "Full deck" : "Wa wa!");

        var evenCards = new List<string>();

        for (int i = 0; i < 52; i++)
        {
            var parityOfIthCard = ((parity >> i) & 1);

            if (parityOfIthCard == 0)
            {
                var suitIndex = i / types.Length;
                var typeIndex = i % types.Length;

                evenCards.Add(types[typeIndex] + "" + suits[suitIndex]);
            }
        }

        Console.WriteLine(string.Join(" ", evenCards));
    }

    static void Main()
    {
        Solve();
    }
}