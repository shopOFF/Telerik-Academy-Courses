using System;

class Decoding
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        double encodedText = 0;

        for (int i = 0; i < text.Length; i++)
        {
            //exit the loop if char=@
            if (text[i] == '@')
            {
                break;
            }
            //if char is a letter 
            if (char.IsLetter(text[i]))
            {
                if (i % 2 == 0)
                {
                    encodedText = ((text[i] * n) + 1000) / 100.0; // za da se presmetne kato tip double ina4e dava dr stoinost 
                    Console.WriteLine("{0:F2}", encodedText);
                }
                else
                {
                    encodedText = ((text[i] * n) + 1000) * 100;
                    Console.WriteLine(encodedText);
                }
                encodedText = 0;
            }
            // if char is a digit
            else if (char.IsDigit(text[i]))
            {
                if (i % 2 == 0)
                {
                    encodedText = (text[i] + n + 500) / 100.0;
                    Console.WriteLine("{0:F2}", encodedText);
                }
                else
                {
                    encodedText = (text[i] + n + 500) * 100;
                    Console.WriteLine(encodedText);
                }
                encodedText = 0;
            }
            // if char is anything else
            else
            {
                if (i % 2 == 0)
                {
                    encodedText = (text[i] - n) / 100.0;
                    Console.WriteLine("{0:F2}", encodedText);
                }
                else
                {
                    encodedText = (text[i] - n) * 100;
                    Console.WriteLine(encodedText);
                }
                encodedText = 0;
            }
        }
    }
}

