namespace CryptoCS
{
    using System;
    using System.Numerics;
    using System.Text;

    class Startup
    {
        static BigInteger FromRadixToDecimal(string input, int radix)
        {
            BigInteger result = 0;

            foreach (var digit in input)
            {
                result = result * radix + digit - (radix == 26 ? 'a' : '0');
            }

            return result;
        }

        static string DecimalTo9(BigInteger dec)
        {
            var result = new StringBuilder();

            do
            {
                result.Insert(0, dec % 9);
                dec /= 9;
            } while (dec > 0);

            return result.ToString();
        }

        static void Main()
        {
            var first = FromRadixToDecimal(Console.ReadLine(), 26);
            var operation = Console.ReadLine();
            var second = FromRadixToDecimal(Console.ReadLine(), 7);

            Console.WriteLine(operation == "+" ? DecimalTo9(first + second) : DecimalTo9(first - second));
        }
    }
}
