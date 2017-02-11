namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesStartUp
    {
        public static void Main()
        {
            var square = new Square(5.5);
            var rectangle = new Rectangle(6.6, 13);
            var triangle = new Triangle(133, 66);

            var collectionOfShapes = new List<Shape>();
            collectionOfShapes.Add(square);
            collectionOfShapes.Add(rectangle);
            collectionOfShapes.Add(triangle);

            foreach (var shape in collectionOfShapes)
            {
                Console.WriteLine("{0} Surface - {1}", shape.GetType().Name, shape.CalcSurface());  // shape.GetType().Name - ни връща типа на текущия обект, shape.CalcSurface() - ни извиква метода CalcSurface() на текущия обект, който ни връща изчисленото лице на дадената фигура...
            }

            // можем и така да си създадем обектите, директно докато ги пълним в листа !!!
            //var collectionOfShapes = new List<Shape>
            //{
            //    new Rectangle(6.6, 13),
            //    new Square(5.5),
            //    new Triangle(133, 66)
            //};
        }
    }
}
