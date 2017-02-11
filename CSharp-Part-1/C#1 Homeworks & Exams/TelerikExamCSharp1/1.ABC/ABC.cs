using System;
using System.Linq;

class ABC
{
    static void Main()
    {
        int numA = int.Parse(Console.ReadLine());
        int numB = int.Parse(Console.ReadLine());
        int numC = int.Parse(Console.ReadLine());
        // mnogo dobro re6enie izpolzvame using System.Linq; i s funkciite na masivite obrabotvame 4islata...Mn dobro re6enie za6oto mojem da sravnqvame ili obrabotvame kakto iskame mn 4isla mnogo barzo i lesno 
        double[] magic = new double[] { numA, numB, numC };
        Console.WriteLine(magic.Max());
        Console.WriteLine(magic.Min());
        Console.WriteLine("{0:F3}", (magic.Sum() / 3));     
    }
}
// Vtori na4in: lesen i prost, kato sravnqvame 4islata dve po dve. 3-ti na4in s if-ove
        //double sum = (numA + numB + numC);

        //Console.WriteLine(Math.Max(Math.Max(numA, numB), numC));
        //Console.WriteLine(Math.Min(Math.Min(numA, numB), numC));
        //Console.WriteLine("{0:F3}", sum / 3);
