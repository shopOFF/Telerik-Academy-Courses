using System;

class SymbolToNumber
{
    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        double encodedText = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }

            if (char.IsLetter(text[i]))
            {
                encodedText = (text[i] * secret) + 1000;
            }
            else if (char.IsDigit(text[i]))
            {
                encodedText = text[i] + secret + 500;
            }
            else
            {
                encodedText = text[i] - secret;
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F2}", (encodedText / 100));
            }
            else
            {
                Console.WriteLine(encodedText * 100);
            }

            encodedText = 0;
        }
    }
}

