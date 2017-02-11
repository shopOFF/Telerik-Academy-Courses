namespace Shapes
{
    // Define class Square and suitable constructor so that at initialization height
    // must be kept equal to width and implement the CalculateSurface() method.
    public class Square : Shape
    {
        public Square(double width)
            : base(width, width)
        {
        }

        public override double CalcSurface()
        {
            return base.Width * base.Width;
        }
    }
}
