using System;

class FindBits
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string mask = Convert.ToString(s, 2).PadLeft(5, '0');
        string bitsToCompare = "";
        int comparingCounter = 0;

        for (int i = 0; i < n; i++)
        {
            int nums = int.Parse(Console.ReadLine());

            string numToBin = Convert.ToString(nums, 2).PadLeft(29, '0');

            for (int e = 0; e <= 29; e++)
            {
                for (int b = 0 + e; b <= 4 + e; b++)
                {
                    if (b == 29)
                    {
                        break;
                    }
                    bitsToCompare += numToBin[b];
                }
                if (mask == bitsToCompare)
                {
                    comparingCounter++;
                }
                bitsToCompare = "";
            }
        }
        Console.WriteLine(comparingCounter);
    }
}

