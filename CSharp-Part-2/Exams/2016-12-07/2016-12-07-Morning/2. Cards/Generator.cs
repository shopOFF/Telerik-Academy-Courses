using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

static class Generator
{
    const long FULL_DECK = (1L << 52) - 1;
    static readonly Random rng = new Random();

    // don't ask
    static readonly List<long> Numbers = Enumerable.Range(0, 1000000)
                                      .Select(x => (long)rng.Next() ^ Guid.NewGuid().GetHashCode())
                                      .Select(Math.Abs)
                                      .OrderBy(x => Guid.NewGuid())
                                      .ToList();

    static int counter = 0;

    static long RND()
    {
        // yes it could crash, but nobody gives a damn (or at least i don't :D)
        return Numbers[counter++];
    }

    /// <summary>
    /// Generate a long with exactly as many bits as passed as parameter
    /// </summary>
    /// <param name="bitsCount"></param>
    /// <returns></returns>
    static long RndLong(int bitsCount)
    {
        // get a random number (product of two other random numbers), clear it's bits in positions [52..63]
        // this will be the result number
        var number = Convert.ToString(RND() * RND() & FULL_DECK, 2).Select(x => x - '0').ToArray();

        var unsetPositions = number.Select((b, i) => b == 0 ? i : -1).Where(x => x != -1).ToList();

        // if the number has less bits than desired, set some
        while (bitsCount > (52 - unsetPositions.Count))
        {
            var currentUnsetPos = rng.Next(0, unsetPositions.Count);
            var pos = unsetPositions[currentUnsetPos];

            number[pos] = 1;

            unsetPositions.RemoveAt(currentUnsetPos);
        }

        var setPositions = number.Select((b, i) => b == 1 ? i : -1).Where(x => x != -1).ToList();

        // if the number has more bits than desired, unset some
        while (setPositions.Count > bitsCount)
        {
            var currentUnsetPos = rng.Next(0, setPositions.Count);
            var pos = setPositions[currentUnsetPos];

            number[pos] = 0;

            setPositions.RemoveAt(currentUnsetPos);
        }

        var bits = string.Join("", number.Reverse());

        return Convert.ToInt64(bits, 2);
    }

    /// <summary>
    /// Generate N hands of cards, that when combined together cannot form at least 1 deck of 52 different cards
    /// </summary>
    /// <param name="n"></param>
    /// <param name="cardsInHand"></param>
    /// <returns></returns>
    static string PartialDeck(int n, int cardsInHand)
    {
        var hands = Enumerable.Range(0, n).Select(x => RndLong(cardsInHand)).ToList();

        var result = hands.Aggregate((m, c) => m | c);

        if (result == FULL_DECK)
        {
            // remove some card types from all hands so no full deck can be formed
            var missingCount = rng.Next(3, 20);

            for (var i = 0; i < missingCount; i++)
            {
                var missingPosition = rng.Next(0, 52);

                for (var j = 0; j < hands.Count; j++)
                {
                    hands[j] &= ~(1L << missingPosition);
                }
            }
        }

        return n + Environment.NewLine + string.Join(Environment.NewLine, hands);
    }

    /// <summary>
    /// Generate N hands, that when combined can form at least a single deck
    /// </summary>
    /// <param name="n"></param>
    /// <param name="cardsInHand"></param>
    /// <returns></returns>
    static string FullDeck(int n, int cardsInHand)
    {
        var hands = Enumerable.Range(0, n).Select(x => RndLong(cardsInHand)).ToList();

        var result = hands.Aggregate((m, c) => m | c);

        for (int i = 0; i < 52; i++)
        {
            var ithBit = (result >> i) & 1;

            // if a card is missing from all hands, put it in some hand
            if (ithBit == 0)
            {
                var handIndex = (int)RND() % hands.Count;

                hands[handIndex] |= 1L << i;
            }
        }

        return n + Environment.NewLine + string.Join(Environment.NewLine, hands);
    }

    public static void Main()
    {
        string[] zeroTests =
        {
                @"3
4503599560261632
67108863
1",
                PartialDeck(5, 3),
                PartialDeck(3, 10),
                FullDeck(3, 40),
                FullDeck(10, 30)
            };

        string[] tests =
        {
                PartialDeck(5, 2),
                PartialDeck(5, 30),
                PartialDeck(7, 20),
                PartialDeck(10, 15),
                FullDeck(5, 40),
                FullDeck(10, 20),
                FullDeck(20, 33),
                FullDeck(50000, 5),
                // 2 big tests, so array solutions can timeout
                PartialDeck(100000, 10),
                FullDeck(100000, 40)
            };

        var folder = "./Tests";

        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }

        for (var i = 0; i < zeroTests.Length; i++)
        {
            var fileName = folder + "/test.000.0" + (i + 1).ToString().PadLeft(2, '0') + ".in.txt";
            Console.WriteLine("Zero input test " + i + " ready");
            File.WriteAllText(fileName, zeroTests[i]);
        }

        for (var i = 0; i < tests.Length; i++)
        {
            var fileName = folder + "/test.0" + (i + 1).ToString().PadLeft(2, '0') + ".in.txt";
            Console.WriteLine("Input test " + i + " ready");
            File.WriteAllText(fileName, tests[i]);
        }
    }
}
