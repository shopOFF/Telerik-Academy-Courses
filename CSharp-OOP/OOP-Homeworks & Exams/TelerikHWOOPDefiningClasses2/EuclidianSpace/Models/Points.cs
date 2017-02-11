namespace EuclideanSpace.Models
{
    using System;
    using System.Linq;

    public struct Points3D
    {
        private static readonly Points3D origin = new Points3D() { X = 0, Y = 0, Z = 0 };

        public Points3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Points3D Origin
        {
            get { return origin; }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Points3D Parse(string text)
        {
            int openPar = text.IndexOf('(');
            double[] coord = text.Substring(openPar + 1, text.Length - openPar - 2)
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            return new Points3D(coord[0], coord[1], coord[2]);
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})", this.X, this.Y, this.Z);
        }


    }
}
