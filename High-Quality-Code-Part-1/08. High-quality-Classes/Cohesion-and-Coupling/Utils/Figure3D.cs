namespace CohesionAndCoupling.Utils
{
    using System;
    using Contracts;

    internal class Figure3D : IDiagonalCalculator2D, IDiagonalCalculator3D
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        public static double Depth { get; set; }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalculateDistance.CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalculateDistance.CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalculateDistance.CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalculateDistance.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }
    }
}
