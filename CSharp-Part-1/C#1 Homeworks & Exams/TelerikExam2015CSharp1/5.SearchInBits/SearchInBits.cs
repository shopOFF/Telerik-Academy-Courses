using System;

class SearchInBits
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int countComparings = 0;
        string matching = "";
        string sToBin = Convert.ToString(s, 2).PadLeft(4,'0');

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string numToBin = Convert.ToString(num, 2).PadLeft(30, '0');

            for (int j = 0; j < 30; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (j + k <= 29)
                    {
                        matching += numToBin[j + k];
                    }
                }
                if (matching == sToBin)
                {
                    countComparings++;
                }
                matching = "";
            }
        }
        Console.WriteLine(countComparings);
    }
}
