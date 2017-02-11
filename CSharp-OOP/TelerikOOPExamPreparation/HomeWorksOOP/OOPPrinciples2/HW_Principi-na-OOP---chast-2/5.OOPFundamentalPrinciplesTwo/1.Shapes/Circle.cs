using System;


namespace _1.Shapes
{
    public class Circle:Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {
        }
        public override double CalculateSurface()
        {
            return Math.PI * this.Width * this.Height;
        }
    }
}
