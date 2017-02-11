namespace Matrixes.Models
{
    using System;
    using System.Text;

    [Version(1, 10)]

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
                firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices should have equal dimensions");
            }
            var result = new Matrix<T>(firstMatrix.matrix.GetLength(0),
                firstMatrix.matrix.GetLength(1));
            for (int r = 0; r < result.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    result[r, c] = (dynamic)firstMatrix[r, c] + (dynamic)secondMatrix[r, c];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0) ||
                firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices should have equal dimensions");
            }
            var result = new Matrix<T>(firstMatrix.matrix.GetLength(0),
                firstMatrix.matrix.GetLength(1));
            for (int r = 0; r < result.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    T max = firstMatrix[r, c];
                    T min = secondMatrix[r, c];
                    if ((dynamic)firstMatrix[r, c] < (dynamic)secondMatrix[r, c])
                    {
                        min = firstMatrix[r, c];
                        max = secondMatrix[r, c];
                    }

                    result[r, c] = (dynamic)max - (dynamic)min;
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(0))  
            {
                throw new ArgumentException("Matrices should have equal dimensions");
            }

            var result = new Matrix<T>(firstMatrix.matrix.GetLength(0),
                secondMatrix.matrix.GetLength(1));
            for (int r = 0; r < result.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    for (int i = 0; i < firstMatrix.matrix.GetLength(1); i++)
                    {
                        result[r, c] += (dynamic)firstMatrix[r, i] * (dynamic)secondMatrix[i, c];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;
            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = true;
            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return !isTrue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    sb.AppendFormat("{0 ,3} ", this.matrix[row, col]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
