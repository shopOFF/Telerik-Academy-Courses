using System;

class ExRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int width = 2 * n + 1;


        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('#', (width / 2) / 2+i), new string('.', d-(i*2)));

        }
        Console.WriteLine("{0}X{1}X{0}", new string('.', (width / 2) / 2 ), new string('#', d));

        
    }
}

