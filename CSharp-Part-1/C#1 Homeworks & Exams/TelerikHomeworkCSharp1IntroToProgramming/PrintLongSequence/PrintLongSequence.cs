using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 0; i < 1000; i += 2)
        {
            Console.WriteLine(2 + i);
            Console.WriteLine(-3 - i);
        }
    }
}