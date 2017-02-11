using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int biggestNum = (Math.Max(Math.Max(a, b), c));
        int smallestNum = (Math.Min(Math.Min(a, b), c));
        double arithmetic = (a + b + c) / 3.00;

        Console.WriteLine(biggestNum);
        Console.WriteLine(smallestNum);
        Console.WriteLine("{0:F2}", arithmetic);
    }
}

