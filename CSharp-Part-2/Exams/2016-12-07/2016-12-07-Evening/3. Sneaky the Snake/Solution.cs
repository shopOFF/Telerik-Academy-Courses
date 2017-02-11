using System;
using System.Linq;

class Solution
{
    const string GET_OUT_MSG = "Sneaky is going to get out with length {0}";
    const string BUMP_IN_ROCK_MSG = "Sneaky is going to hit a rock at [{1},{2}]";
    const string LOST_IN_DEPTHS_MSG = "Sneaky is going to be lost into the depths with length {0}";
    const string STARVE_MSG = "Sneaky is going to starve at [{1},{2}]";
    const string STILL_IN_DEN_MSG = "Sneaky is going to be stuck in the den at [{1},{2}]";

    const int looseWeightMoveCount = 5;

    static char[,] field;
    static char[] moves;
    static int[] pos;
    static int[] dir = { 1, 0 };
    static int snakeLength = 3;

    static void Main()
    {
        // read input
        int[] size = Console.ReadLine().Split('x').Select(int.Parse).ToArray();
        field = ReadField(size[0], size[1]);
        moves = Console.ReadLine().Split(',').Select(x => x[0]).ToArray();

        string message = STILL_IN_DEN_MSG;
        bool canContinue = true;
        for (int i = 0; i < moves.Length && canContinue; i++)
        {
            ExecuteMove(moves[i]);
            snakeLength -= (i != 0 && (i + 1) % looseWeightMoveCount == 0) ? 1 : 0;

            if (snakeLength <= 0)
            {
                message = STARVE_MSG;
                canContinue = false;
                break;
            }

            if (pos[0] >= field.GetLength(0))
            {
                message = LOST_IN_DEPTHS_MSG;
                canContinue = false;
                break;
            }

            CheckForRightLeftLoop();
            switch (field[pos[0], pos[1]])
            {
                case '-': break;
                case '@':
                    snakeLength++;
                    field[pos[0], pos[1]] = '.';
                    break;
                case '%':
                    message = BUMP_IN_ROCK_MSG;
                    canContinue = false;
                    break;
                case 'e':
                    message = GET_OUT_MSG;
                    canContinue = false;
                    break;
            }
        }

        Console.WriteLine(message, snakeLength, pos[0], pos[1]);
    }

    private static char[,] ReadField(int rows, int cols)
    {
        char[,] field = new char[rows, cols];

        string line;
        for (int row = 0; row < rows; row++)
        {
            line = Console.ReadLine();
            for (int col = 0; col < cols; col++)
            {
                field[row, col] = line[col];
                if (line[col] == 'e')
                {
                    pos = new int[] { row, col };
                }
            }
        }

        return field;
    }

    private static void ExecuteMove(char move)
    {
        switch (move)
        {
            case 's': pos[0]++; break;
            case 'w': pos[0]--; break;
            case 'd': pos[1]++; break;
            case 'a': pos[1]--; break;
        }
    }

    private static void CheckForRightLeftLoop()
    {
        if (pos[1] < 0)
        {
            pos[1] = field.GetLength(1) - 1;
        }
        else if (pos[1] >= field.GetLength(1))
        {
            pos[1] = 0;
        }
    }
}