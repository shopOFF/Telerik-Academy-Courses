using System;

class BiggestOf3
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        if (numA > numB && numA > numC)
        {
            Console.WriteLine(numA);
        }
        else if (numB > numA && numB > numC)
        {
            Console.WriteLine(numB);
        }
        else
        {
            Console.WriteLine(numC);
        }
    }
}

