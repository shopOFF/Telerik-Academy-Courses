using System;

class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int count = n - 3;
        Console.WriteLine("{0}{1}", new string(':', n), new string(' ', n - 1));

        Console.WriteLine("{0}{1}::{2}", new string(':', 1), new string(' ', n - 2), new string(' ', n - 2));

        for (int i = 1; i <= n / 2 ; i++)
        {
            Console.WriteLine("{0}{1}:{2}:{3}", new string(':', 1), new string(' ', n - 2), new string('|', i), new string(' ', count));
            count++;
        }

        Console.WriteLine("{0}{1}:", new string(':', n), new string('|', n / 2 + 1));

        for (int i = n / 2 ; i >= 1; i--)
        {
            Console.WriteLine("{0}:{1}:{2}:", new string(' ', counter++), new string('-', n - 2), new string('|', i));
        }

        Console.WriteLine("{0}:{1}{2}", new string(' ', counter), new string('-', n - 2), new string(':', 2));

        Console.WriteLine("{0}{1}", new string(' ', ++counter), new string(':', n));

    }
}
