namespace EuclideanSpace
{
    using System;
    using Models;
    using Extensions;

    class EuclideanSpace
    {
        static void Main()
        {
            Points3D point = new Points3D(1, 2, 3);
            Console.WriteLine(point);
            Console.WriteLine(Points3D.Origin);

            var dist = Point3DExtensions.CalculateDistance(point, Points3D.Origin);

            Console.WriteLine("The distance between the two points is: {0}",dist);

            var path = new Path();
            for (int i = 0; i < 10; i++)
            {
                path.AddPoint(new Points3D() { X = i, Y = i * 2, Z = i + 3 });
            }

            string pathStr = "../../path.txt";
            PathStorage.SavePath(path, "../../path.txt");
            var pathFromFile = PathStorage.LoadPath("../../path.txt");

            Console.WriteLine("The points from the text file are:");
            foreach (var p in pathFromFile)
            {
                Console.WriteLine(p);
            }
        }
    }
}
