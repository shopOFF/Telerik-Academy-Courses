using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static double CalculateTriangleSurfaceBy2SidesAndAngle(double lengthSideA, double lengthSideB, double angle)
    {
        double surface = ((lengthSideA * lengthSideB) * (Math.Sin((Math.PI * angle) / 180))) / 2;
        return surface;
    }
    static void Main()
    {
        double lengthSideA = double.Parse(Console.ReadLine());
        double lengthSideB = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", CalculateTriangleSurfaceBy2SidesAndAngle(lengthSideA, lengthSideB, angle));
    }
}