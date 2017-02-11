using System;
using System.Numerics;

class ConsoleApplication1
{
    static void Main()
    {
        BigInteger allProducts = 1;
        BigInteger product = 1;

        for (int i = 0; i < 10000; i++)
        {
            string n = Console.ReadLine();
            if (n == "END")
            {
                break;
            }
            if (i % 2 != 0)
            {
                foreach (char digit in n)
                {
                    if (digit == '0')
                    {
                        continue;
                    }
                    product *= digit - '0';
                }
                allProducts *= product;
                product = 1;
            }
            if (i == 9)
            {
                Console.WriteLine(allProducts);
                allProducts = 1;
            }
        }
        Console.WriteLine(allProducts);
    }
}