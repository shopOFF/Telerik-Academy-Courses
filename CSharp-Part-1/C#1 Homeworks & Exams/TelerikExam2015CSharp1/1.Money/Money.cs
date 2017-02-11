using System;

class Money
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal totalSheetsOfPaper = n * s;
        decimal reamFinder = totalSheetsOfPaper / 400;
        decimal reamPrice = reamFinder * p;

        Console.WriteLine("{0:F3}",reamPrice);
    }
}
