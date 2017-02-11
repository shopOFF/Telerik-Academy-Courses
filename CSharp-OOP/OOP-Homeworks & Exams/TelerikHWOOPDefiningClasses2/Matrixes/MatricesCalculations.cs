namespace Matrixes
{
    using System;
    using Models;

    public class MatricesCalculations
    {
        static void Main()
        {
            int row = 6;
            int col = 6;
            var firstMatrix = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    firstMatrix[r, c] = r + c + 2;
                }
            }

            row = 6;
            col = 6;
            var secondMatrix = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    secondMatrix[r, c] = r + c;
                }
            }
            Console.WriteLine("First Matrix:");
            Console.WriteLine(firstMatrix);
            Console.WriteLine("Second Matrix:");
            Console.WriteLine(secondMatrix);

            Console.WriteLine("First Matrix + Second Matrix:");
            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine("First Matrix - Second Matrix:");
            Console.WriteLine(firstMatrix - secondMatrix);
            Console.WriteLine("First Matrix * Second Matrix:");
            Console.WriteLine(firstMatrix * secondMatrix);


            if (secondMatrix)
            {
                Console.WriteLine("There are no zero elements!");
            }
            else
            {
                Console.WriteLine("There are zero elements!");
            }

            Type type = typeof(Matrix<int>);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var item in attributes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
