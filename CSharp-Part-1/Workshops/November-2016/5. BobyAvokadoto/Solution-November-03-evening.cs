using System;

namespace BobiAvokadoto
{
    class StartUp
    {
        static void Main()
        {
            uint head = uint.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int bestToothCount = -5;
            uint bestComb = 0;

            for (int i = 0; i < c; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                if ((comb & head) != 0)
                {
                    continue;
                }
                //bool canUseComb = true;
                int toothCount = 0;

                for (int j = 0; j < 32; ++j)
                {
                    //uint hasHair = (head >> j) & 1;
                    uint hasTooth = (comb >> j) & 1;
                    //if (hasHair == 1 && hasTooth == 1)
                    //{
                    //    canUseComb = false;
                    //    break;
                    //}
                    if (hasTooth == 1)
                    {
                        ++toothCount;
                    }
                }

                //if (canUseComb)
                //{
                    //Console.WriteLine("{0} {1}", comb, toothCount);

                    // bestToothCount = Math.Max(bestToothCount, toothCount);
                    if (toothCount > bestToothCount)
                    {
                        bestToothCount = toothCount;
                        bestComb = comb;
                    }
                //}
            }

            Console.WriteLine(bestComb);
        }
    }
}
