namespace Messages
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Startup
    {
        static string[] digits = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        static void Main()
        {
            string xString = Console.ReadLine();
            var xNumber = FromMessageToDec(xString);

            var sign = char.Parse(Console.ReadLine());

            string yString = Console.ReadLine();

            BigInteger yNumber = FromMessageToDec(yString);

            BigInteger zNumber = (sign == '+')
                    ? xNumber + yNumber
                    : xNumber - yNumber;

            string result = FromDecToMessage(zNumber);
            Console.WriteLine(result);
        }

        static string FromDecToMessage(BigInteger number)
        {
            BigInteger b = digits.Length;
            List<string> message = new List<string>();
            while (number > 0)
            {
                int digitIndex = (int)(number % b);
                message.Add(digits[digitIndex]);
                number /= b;
            }

            message.Reverse();
            return string.Join("", message);
        }

        static BigInteger FromMessageToDec(string text)
        {
            BigInteger number = 0;
            BigInteger power = 1;
            BigInteger b = digits.Length;

            for (int index = text.Length - 1; index >= 0; index -= 3)
            {
                var digit = text.Substring(index - 2, 3);
                number += (BigInteger)Array.IndexOf(digits, digit) * power;
                power *= b;
            }
            return number;
        }
    }
}
