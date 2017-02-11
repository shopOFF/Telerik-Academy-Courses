﻿namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalcSurface()
        {
            return (base.Width * base.Height) / 2;
        }
    }
}
