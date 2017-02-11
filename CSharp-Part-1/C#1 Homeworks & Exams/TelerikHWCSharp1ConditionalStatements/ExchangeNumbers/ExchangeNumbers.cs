using System;

class ExchangeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double temp = 0;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }

    }
}

