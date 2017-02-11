using System;

class BiggestОf5
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());
        double numD = double.Parse(Console.ReadLine());
        double numE = double.Parse(Console.ReadLine());

        if (numA > numB && numA > numC && numA > numD && numA > numE)
        {
            Console.WriteLine(numA);
        }
        else if (numB > numA && numB > numC && numB > numD && numB > numE)
        {
            Console.WriteLine(numB);
        }
        else if (numC > numA && numC > numB && numC > numD && numC > numE)
        {
            Console.WriteLine(numC);
        }
        else if (numD > numA && numD > numB && numD > numC && numD > numE)
        {
            Console.WriteLine(numD);
        }
        else
        {
            Console.WriteLine(numE);
        }

    }
}

