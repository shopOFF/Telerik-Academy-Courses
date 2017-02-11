namespace CohesionAndCoupling
{
    using System;
    using Utils;

    internal class UtilsExamples
    {
        internal static void Main()
        {
            Console.WriteLine(GetFileName.GetFileExtension("example"));
            Console.WriteLine(GetFileName.GetFileExtension("example.pdf"));
            Console.WriteLine(GetFileName.GetFileExtension("example.new.pdf"));

            Console.WriteLine(GetFileName.GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFileName.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFileName.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalculateDistance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalculateDistance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D.Width = 13;
            Figure3D.Height = 4;
            Figure3D.Depth = 5;

            var figure = new Figure3D();

            Console.WriteLine("Volume = {0:f2}", Figure3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}
