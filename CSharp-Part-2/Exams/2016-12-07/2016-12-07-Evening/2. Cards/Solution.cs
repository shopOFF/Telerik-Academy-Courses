using System;
using System.IO;
using System.Collections.Generic;

class Solution
{
    private enum TestType
    {
        Zero = 0,
        Regular = 1
    }

    private class TestIO : IDisposable
    {
        private const string testPathFormat = "./Tests/test.0{0}.in.txt";
        private const string zeroTestPathFormat = "./Tests/test.000.0{0}.in.txt";

        private StreamReader reader;
        private StreamWriter writer;

        private TextReader consoleReader;
        private TextWriter consoleWriter;

        public TestIO(int inputTestNumber, TestType testType = TestType.Regular)
        {
            var test = inputTestNumber.ToString().PadLeft(2, '0');
            var testPath = string.Format(testType == TestType.Zero ? zeroTestPathFormat : testPathFormat, test);

            reader = new StreamReader(testPath);
            writer = new StreamWriter(testPath.Replace(".in.", ".out."));

            this.SetConsoleIO();
        }

        private void SetConsoleIO()
        {
            this.consoleReader = Console.In;
            this.consoleWriter = Console.Out;

            Console.SetIn(this.reader);
            Console.SetOut(this.writer);
        }

        public void Dispose()
        {
            this.reader.Close();

            this.writer.Flush();
            this.writer.Close();

            Console.SetOut(this.consoleWriter);
            Console.SetIn(this.consoleReader);
        }
    }

    static void Main(string[] args)
    {
        if (args == null || args.Length == 0 || args[0] != "--testgen")
        {
            Solve();
        }
        else
        {
            const int zeroTestCount = 4;
            const int testCount = 10;

            for (var i = 1; i <= zeroTestCount; i++)
            {
                using (new TestIO(i, TestType.Zero))
                {
                    Solve();
                }

                Console.WriteLine("Zero output test {0} ready", i);
            }

            for (var i = 1; i <= testCount; i++)
            {
                using (new TestIO(i))
                {
                    Solve();
                }

                Console.WriteLine("Output test {0} ready", i);
            }
        }
    }

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

            if (parityOfIthCard == 1)
            {
                var suitIndex = i / types.Length;
                var typeIndex = i % types.Length;

                evenCards.Add(types[typeIndex] + "" + suits[suitIndex]);
            }
        }

        Console.WriteLine(string.Join(" ", evenCards));
    }
}