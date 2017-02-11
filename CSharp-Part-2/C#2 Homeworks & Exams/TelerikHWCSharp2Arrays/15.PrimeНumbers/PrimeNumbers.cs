//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class PrimeНumbers
//{
//    static void Main()
//    {
//        int num = int.Parse(Console.ReadLine());
//        List<int> primeNums = new List<int>();
//        for (int i = 0; i <= num; i++)
//        {
//            bool isPrime = true; // Move initialization to here
//            for (long j = 2; j < i; j++) // you actually only need to check up to sqrt(i)
//            {
//                if (i % j == 0) // you don't need the first condition
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//            if (isPrime)
//            {
//                primeNums.Add(i);
//            }
//            // isPrime = true;
//        }
//        Console.WriteLine(primeNums.Max());
//    }
//}

using System;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n+1]; // new bool[10000000];

        // Find all prime numbers to N
        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            // Skip these which is not prime
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j += i)
                    primes[j] = true;
            }
        }
        int prime = 0;
        // Print all prime numbers to N
        for (int i = 2; i < primes.Length; i++)
            if (!primes[i])
            {
                 prime = i;
            }
        Console.WriteLine(prime);
    }
}