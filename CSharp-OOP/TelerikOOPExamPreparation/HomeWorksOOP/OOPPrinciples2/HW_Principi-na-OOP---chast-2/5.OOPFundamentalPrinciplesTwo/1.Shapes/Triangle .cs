using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public class Triangle : Shape
    {

        //Constructor
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        //implementing virtual method
        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }

    }
}
