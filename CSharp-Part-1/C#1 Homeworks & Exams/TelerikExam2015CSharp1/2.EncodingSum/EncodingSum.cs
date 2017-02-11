using System;

class EncodingSum
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string inputText = Console.ReadLine();
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int letterAsNum = 0;
        long encodedResult = 0;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == '@')
            {
                break;
            }
            if (char.IsLetter(inputText[i]))
            {
                for (int a = 0; a < alphabet.Length; a++)
                {
                    if (alphabet[a]==char.ToUpper(inputText[i]))
                    {
                        letterAsNum = a;
                        break;
                    }
                }
                encodedResult += letterAsNum;
                letterAsNum = 0;
            }
            else if (char.IsDigit(inputText[i]))
            {
                encodedResult *= inputText[i] - '0';
            }
            else
            {
                encodedResult %= m;
            }

        }
        Console.WriteLine(encodedResult);
    }
}

