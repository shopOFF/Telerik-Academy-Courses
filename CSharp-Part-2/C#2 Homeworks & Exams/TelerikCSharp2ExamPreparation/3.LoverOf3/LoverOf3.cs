using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LoverOf3
{
    static int CheckingDirectionAndSumingCells(int[,] field, string[] direction, int[] moves)
    {
        int sum = 0;
        int row = field.GetLength(0) - 1;
        int col = 0;

        for (int i = 0; i < moves.Length; i++)
        {
            if (direction[i] == "RU" || direction[i] == "UR")
            {
                for (int j = 0; j < moves[i]; j++)
                {
                    if (moves[i] - 1 != j)
                    {
                        row--;
                        col++;
                    }
                    sum += field[row, col];
                    field[row, col] = 0;

                }
            }
            if (direction[i] == "DR" || direction[i] == "RD")
            {
                for (int j = 0; j < moves[i]; j++)
                {
                    if (moves[i] - 1 != j)
                    {
                        row++;
                        col++;
                    }
                    sum += field[row, col];
                    field[row, col] = 0;

                }
            }
            if (direction[i] == "DL" || direction[i] == "LD")
            {
                for (int j = 0; j < moves[i]; j++)
                {
                    if (moves[i] - 1 != j && row != 0 && col != 0)
                    {
                        row++;
                        col--;
                    }
                    sum += field[row, col];
                    field[row, col] = 0;

                }
            }
            if (direction[i] == "LU" || direction[i] == "UL")
            {
                for (int j = 0; j < moves[i]; j++)
                {
                    if (moves[i] - 1 != j && row != 0 && col != 0)
                    {
                        row--;
                        col--;
                    }
                    sum += field[row, col];
                    field[row, col] = 0;

                }
            }
        }
        return sum;
    }
    static int[,] FillingField(int rows, int cols)
    {
        int numRowCounter = 0;
        int numColCounter = 0;
        int[,] field = new int[rows, cols];
        for (int row = rows - 1; row >= 0; row--)
        {
            for (int col = 0; col < cols; col++)
            {
                field[row, col] = numColCounter;
                numColCounter += 3;
            }
            numRowCounter += 3;
            numColCounter = numRowCounter;
        }
        return field;
    }
    static void Main()
    {
        int[] fieldDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberOfMoves = int.Parse(Console.ReadLine());
        string[] directionAndNumberOfMoves = new string[2];

        int[,] field = FillingField(fieldDimensions[0], fieldDimensions[1]);
        string[] direction = new string[numberOfMoves];
        int[] moves = new int[numberOfMoves];
        int sumOfCells = 0;

        for (int i = 0; i < numberOfMoves; i++)
        {
            directionAndNumberOfMoves = Console.ReadLine().Split(' ');
            direction[i] = directionAndNumberOfMoves[0];
            moves[i] = int.Parse(directionAndNumberOfMoves[1]);
        }
        sumOfCells += CheckingDirectionAndSumingCells(field, direction, moves);
        Console.WriteLine(sumOfCells);
    }
}