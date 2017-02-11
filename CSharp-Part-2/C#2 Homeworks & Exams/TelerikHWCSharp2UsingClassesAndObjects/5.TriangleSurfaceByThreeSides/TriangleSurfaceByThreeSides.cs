using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurfaceByThreeSides
{
    static double CalculateTriangleSurfaceBy3Sides(double lengthSideA, double lengthSideB, double lengthSideC)
    {
        double s = (lengthSideA + lengthSideB + lengthSideC) / 2;
        double surface = Math.Sqrt(s * ((s - lengthSideA) * (s - lengthSideB) * (s - lengthSideC)));
        return surface;
    }
    static void Main()
    {
        double lengthSideA = double.Parse(Console.ReadLine());
        double lengthSideB = double.Parse(Console.ReadLine());
        double lengthSideC = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", CalculateTriangleSurfaceBy3Sides(lengthSideA, lengthSideB, lengthSideC));
    }
}