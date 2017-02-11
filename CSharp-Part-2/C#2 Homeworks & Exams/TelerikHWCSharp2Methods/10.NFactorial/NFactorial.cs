using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NFactorial
{
    static BigInteger  CalculateFactorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculateFactorial(n));
    }
}