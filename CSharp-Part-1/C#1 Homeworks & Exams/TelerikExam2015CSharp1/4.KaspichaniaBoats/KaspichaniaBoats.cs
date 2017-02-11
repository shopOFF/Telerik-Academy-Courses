using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //top
        Console.Write(new string('.', n));
        Console.Write('*');
        Console.Write(new string('.', n));

        Console.WriteLine();

        Console.Write(new string('.', n - 1));
        Console.Write(new string('*', 3));
        Console.Write(new string('.', n - 1));

        Console.WriteLine();

        //top middle loop
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', n - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', 1 + i));
            Console.Write('*');
            Console.Write(new string('.', 1 + i));
            Console.Write('*');
            Console.Write(new string('.', n - 2 - i));

            Console.WriteLine();
        }

        //middle
        Console.Write(new string('*', n * 2 + 1));

        Console.WriteLine();

        // lower loop
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', 1 + i));
            Console.Write('*');
            Console.Write(new string('.', n - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', n - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', 1 + i));

            Console.WriteLine();
        }

        // bottom
        Console.Write(new string('.', n / 2 + 1));
        Console.Write(new string('*', n));
        Console.Write(new string('.', n / 2 + 1));
    }
}

