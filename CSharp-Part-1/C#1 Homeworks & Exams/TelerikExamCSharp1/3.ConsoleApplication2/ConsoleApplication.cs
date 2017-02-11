using System;
using System.Numerics;
class ConsoleApplication
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        long[] productArr = new long[10000];
        long calculation = 1;
        BigInteger productTo10 = 1;
        BigInteger productAfter10 = 1;


        for (int i = 0; i <= 10000; i++)
        {
            if (numbers == "END")
            {
                break;
            }
            if (i % 2 == 0)
            {
                if (numbers == "0")
                {
                    numbers = "1";
                }
                foreach (var item in numbers)
                {
                    if (item!='0')
                    {
                        calculation *= item - '0';
                    }
                    else
                    {
                        calculation *= 1;
                    }
                }
                productArr[i] += calculation;
                
                calculation = 1;
            }
            if (i == 9)
            {
                foreach (var prod in productArr)
                {
                    if (prod != 0)
                    {
                        productTo10 *= prod;
                    }
                }
                Console.WriteLine(productTo10);
                Array.Clear(productArr, 0, productArr.Length); // clears the array 
            }
            numbers = Console.ReadLine();
        }
        foreach (var nums in productArr)
        {
            if (nums!=0)
            {
                productAfter10 *= nums;
            }
        }
        Console.WriteLine(productAfter10);
    }
}

