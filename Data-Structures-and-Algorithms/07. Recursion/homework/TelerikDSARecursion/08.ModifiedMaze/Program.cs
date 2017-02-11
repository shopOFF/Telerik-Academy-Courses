using System;

namespace ModifiedMaze
{
   public class Program
    {
        private static string[,] maze;

        public static void Main()
        {
            maze = new string[,]
            {
                {" ", " ", " ", " ", " ", " "},
                {" ", "x", "x", "x", "x", " "},
                {" ", "*", "x", " ", "x", " "},
                {"x", "x", " ", " ", " ", "e"},
                {" ", "x", " ", "x", "x", " "},
                {" ", " ", " ", "x", " ", "x"},
            };

            var startCell = new Cell<int>(-1, -1);
            FindStartingCell(startCell, maze);

            try
            {
                Console.WriteLine(FindPaths(startCell.Row, startCell.Col, false));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There is no start position '*' provided in the maze");
            }
        }

        private static bool FindPaths(int row, int col, bool check)
        {
            if (maze[row, col] == "e")
            {
                return true;
            }

            maze[row, col] = "o";

            if (row > 0 && maze[row - 1, col] != "x" && maze[row - 1, col] != "o")
            {
                check = FindPaths(row - 1, col, check);
            }

            if (row + 1 < maze.GetLength(0) && maze[row + 1, col] != "x" && maze[row + 1, col] != "o")
            {
                check = FindPaths(row + 1, col, check);
            }
            if (col > 0 && maze[row, col - 1] != "x" && maze[row, col - 1] != "o")
            {
                check = FindPaths(row, col - 1, check);
            }
            if (col + 1 < maze.GetLength(1) && maze[row, col + 1] != "x" && maze[row, col + 1] != "o")
            {
                check = FindPaths(row, col + 1, check);
            }

            maze[row, col] = " ";

            return check;
        }

        private static void FindStartingCell(Cell<int> startCell, string[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == "*")
                    {
                        startCell.Row = i;
                        startCell.Col = j;
                    }
                }
            }
        }
    }
}
