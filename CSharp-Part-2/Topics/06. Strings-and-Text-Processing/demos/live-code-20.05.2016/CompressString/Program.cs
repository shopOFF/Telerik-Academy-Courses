namespace CompressString
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        { 
            // compress a string by replacing a sequences of repeating characters with the character followed by the count of the repetitions
            var text = "aaaaaaaaaaaababab bc aaaaaaaa bbbbbbbbb gosho tosho oooooooo penkeeeeeeeee";

            var compressed = new StringBuilder();

            int currentLetterCount = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] == text[i])
                {
                    currentLetterCount++;
                }
                else
                {
                    compressed.Append(text[i - 1]);

                    if (currentLetterCount >= 2)
                    {
                        compressed.Append(currentLetterCount);
                    }

                    currentLetterCount = 1;
                }
            }

            compressed.Append(text[text.Length - 1]);

            if (currentLetterCount >= 2)
            {
                compressed.Append(currentLetterCount);
            }

            Console.WriteLine(compressed);
        }
    }
}
