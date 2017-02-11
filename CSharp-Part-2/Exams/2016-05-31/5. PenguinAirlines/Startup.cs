namespace PenguinAirlines
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            DisjointSetInit(n);

            int[][] neigh = new int[n][];

            for (int i = 0; i < n; ++i)
            {
                string line = Console.ReadLine();
                if (line == "None")
                {
                    continue;
                }

                neigh[i] = line.Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                foreach (int j in neigh[i])
                {
                    Unite(i, j);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Have a break")
                {
                    break;
                }

                string[] ab = line.Split(' ');
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);

                if (Connected(a, b))
                {
                    if (Array.IndexOf(neigh[a], b) < 0)
                    {
                        Console.WriteLine("There are flights, unfortunately they are not direct, grandma :(");
                    }
                    else
                    {
                        Console.WriteLine("There is a direct flight.");
                    }
                }
                else
                {
                    Console.WriteLine("No flights available.");
                }
            }
        }

        static int[] dsData;

        static void DisjointSetInit(int n)
        {
            dsData = new int[n];
            for (int i = 0; i < n; ++i)
            {
                dsData[i] = -1;
            }
        }

        static int Find(int x)
        {
            return dsData[x] < 0 ? x : (dsData[x] = Find(dsData[x]));
        }

        static bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }

        static bool Unite(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (x == y)
            {
                return false;
            }

            dsData[x] = y;
            return true;
        }
    }
}
