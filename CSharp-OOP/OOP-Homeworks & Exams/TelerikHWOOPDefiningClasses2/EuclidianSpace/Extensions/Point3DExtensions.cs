namespace EuclideanSpace.Extensions
{
    using System;
    using Models;

    public static class Point3DExtensions
    {
        public static double CalculateDistance(Points3D firstPoint, Points3D secondPoint)
        {
            double distance = 0.0;
            distance = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                                 (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
                                 (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
            return distance;
        }

    }
}
