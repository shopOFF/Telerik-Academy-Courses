using System;
using System.Numerics;

class Maslan
{
    static void Main()
    {
        string num = Console.ReadLine();

        string newNum = "";
        BigInteger oddNum = 0;
        BigInteger oddNumProduct = 1;
        int transformationCounter = 0;

        while (oddNumProduct > 10 || transformationCounter != 10)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    newNum += num[j];
                    if (j % 2 != 0)
                    {
                        oddNum += newNum[j] - '0';
                    }
                }
                if (oddNum > 0)
                {
                    oddNumProduct *= oddNum;
                }
                num = newNum;
                newNum = "";
                oddNum = 0;
            }
            num = Convert.ToString(oddNumProduct);
            transformationCounter++;

            if (oddNumProduct > 10 && transformationCounter < 10)
            {
                oddNumProduct = 1;
            }
            else if (transformationCounter == 10)
            {
                Console.WriteLine(num);
                break;
            }
            else
            {
                Console.WriteLine(transformationCounter);
                Console.WriteLine(num);
                break;
            }
        }
    }
}

