namespace Shapes
{
    using System;
    public abstract class Shape
    {
        private double width;

        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can not be zero or less!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can not be zero or less!");
                }
                this.height = value;
            }
        }


        public abstract double CalcSurface();
    }
}
