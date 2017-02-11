using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurfaceBySideAndAltitude
{
    static double CalculateTriangleSurface(double lengthOfSide, double altitude)
    {
        double surface = (lengthOfSide * altitude) / 2;
        return surface;
    }
    static void Main()
    {
        double lengthOfSide = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}",CalculateTriangleSurface(lengthOfSide,altitude));
    }
}