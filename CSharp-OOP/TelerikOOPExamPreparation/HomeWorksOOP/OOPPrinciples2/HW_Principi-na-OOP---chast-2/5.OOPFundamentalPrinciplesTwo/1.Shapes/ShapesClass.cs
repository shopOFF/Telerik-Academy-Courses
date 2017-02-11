//  1.Define abstract class Shape with only one abstract method CalculateSurface()
//  and fields width and height. Define two new classes Triangle and Rectangle 
//  that implement the virtual method and return the surface of the figure 
//  (height*width for rectangle and height*width/2 for triangle). Define class 
//  Circle and suitable constructor so that at initialization height must be kept equal 
//  to width and implement the CalculateSurface() method. Write a program that tests the 
//  behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) 
//  stored in an array.


using System;


namespace _1.Shapes
{
    class ShapesClass
    {
        static void Main(string[] args)
        {

            Shape[] shapesArray = new Shape[] 
            {
                new Circle(3),
                new Triangle(2,4),
                new Rectangle(3,5)
            };

            foreach (var shape in shapesArray)
            {
                Console.WriteLine("{0} surface is {1:f3}", shape.GetType().Name, shape.CalculateSurface());
            }

        }
    }
}
