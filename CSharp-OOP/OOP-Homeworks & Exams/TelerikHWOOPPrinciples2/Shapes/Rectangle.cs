namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        public override double CalcSurface()
        {
            return base.Width * base.Height;
        }
    }
}
