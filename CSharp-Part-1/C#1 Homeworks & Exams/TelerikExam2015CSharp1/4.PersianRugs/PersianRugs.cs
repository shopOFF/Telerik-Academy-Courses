using System;

class PersianRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int width = n * 2 + 1;

        // upper loop
        for (int i = 0; i < n; i++)
        {
            int dotCounter = width - i - i - d - d - 2 - 2; // ili ((width - (i * 2)) - d * 2) - 2 * 2 nqma zna4enie // mnogo dobro re6enie promenlivata da e vatre i dase updeitva s vsqka iteraciq, taka namirame to4kite v malkiq triagalnik
            if (d > n)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('#', i), new string(' ', (width - 2) - (i * 2)));
            }
            else
            {
                if (dotCounter >= 1)
                {
                    Console.WriteLine("{0}\\{1}\\{2}/{1}/{0}", new string('#', i), new string(' ', d), new string('.', dotCounter));
                }
                else
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('#', i), new string(' ', (width - 2) - (i * 2)));
                }
            }
        }

        // middle
        Console.WriteLine("{0}X{0}", new string('#', n));

        //lower loop
        for (int i = n - 1; i >= 0; i--)
        {
            int dotCounter = ((width - (i * 2)) - d * 2) - 2 * 2; // mnogo dobro re6enie promenlivata da e vatre i dase updeitva s vsqka iteraciq
            if (d > n)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('#', i), new string(' ', (width - 2) - (i * 2)));
            }
            else
            {
                if (dotCounter >= 1)
                {
                    Console.WriteLine("{0}/{1}/{2}\\{1}\\{0}", new string('#', i), new string(' ', d), new string('.', dotCounter));
                }
                else
                {
                    Console.WriteLine("{0}/{1}\\{0}", new string('#', i), new string(' ', (width - 2) - (i * 2)));
                }
            }
        }
    }
}

