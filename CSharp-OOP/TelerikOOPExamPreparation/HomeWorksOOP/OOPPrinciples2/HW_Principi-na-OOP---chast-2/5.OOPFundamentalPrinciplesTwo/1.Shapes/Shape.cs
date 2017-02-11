using System;
using System.Linq;


namespace _1.Shapes
{
    public abstract class Shape
    {

        //Fields
        protected double width;
        protected double height;

        //Properties
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width have to be positive.");
                }
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height have to be positive.");
                }
                height = value;
            }
        }

        //Constructors
        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }


        //Virtual Method
        public abstract double CalculateSurface();
    }
}
