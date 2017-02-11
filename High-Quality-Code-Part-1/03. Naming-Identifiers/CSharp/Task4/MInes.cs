namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public class Points
        {
            private string name;
            private int pointsCount;

            public Points(string name, int points)
            {
                this.name = name;
                this.pointsCount = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int PointsCount
            {
                get { return this.pointsCount; }
                set { this.pointsCount = value; }
            }
        }

        public static void Main()
        {
            const int MAX_FIELDS = 35;
            bool firstFlag = true;
            bool secondFlag = false;
            bool expload = false;
            int row = 0;
            int col = 0;
            int counter = 0;
            string command = string.Empty;
            char[,] field = CrateGameField();
            char[,] bombs = PlaceMines();
            List<Points> champions = new List<Points>(6);

            do
            {
                if (firstFlag)
                {
                    Console.WriteLine("Lets play \"Mines\". Try to find the fields without mines." +
                         "Command \"top\" shows the score board, \"restart\" starts a new game, \"exit\" exits from the game!");
                    Place(field);
                    firstFlag = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ScoreBoard(champions);
                        break;
                    case "restart":
                        field = CrateGameField();
                        bombs = PlaceMines();
                        Place(field);
                        expload = false;
                        firstFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                NextMove(field, bombs, row, col);
                                counter++;
                            }

                            if (MAX_FIELDS == counter)
                            {
                                secondFlag = true;
                            }
                            else
                            {
                                Place(field);
                            }
                        }
                        else
                        {
                            expload = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Unvalid command\n");
                        break;
                }

                if (expload)
                {
                    Place(bombs);
                    Console.Write("\nHrrrrrr! You died with {0} points. Write your nickname: ", counter);
                    string nickname = Console.ReadLine();

                    Points points = new Points(nickname, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(points);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].PointsCount < points.PointsCount)
                            {
                                champions.Insert(i, points);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points firstPlayer, Points secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Points firstPlayer, Points secondPlayer) => secondPlayer.PointsCount.CompareTo(firstPlayer.PointsCount));

                    ScoreBoard(champions);

                    field = CrateGameField();
                    bombs = PlaceMines();
                    counter = 0;
                    expload = false;
                    firstFlag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nBRAVOOO! You steppted on 35 fields without a drop of bload.");
                    Place(bombs);
                    Console.WriteLine("Enter your name, dude: ");

                    string name = Console.ReadLine();
                    Points points = new Points(name, counter);

                    champions.Add(points);
                    ScoreBoard(champions);
                    field = CrateGameField();
                    bombs = PlaceMines();
                    counter = 0;
                    secondFlag = false;
                    firstFlag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("COME ON.");
            Console.Read();
        }

        private static void ScoreBoard(List<Points> points)
        {
            Console.WriteLine("\nPoints:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].PointsCount);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void NextMove(char[,] field, char[,] mines, int row, int col)
        {
            char kolkoBombi = Place(mines, row, col);
            mines[row, col] = kolkoBombi;
            field[row, col] = kolkoBombi;
        }

        private static void Place(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CrateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int row = 5;
            int col = 10;
            char[,] gameField = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> newRow = new List<int>();

            while (newRow.Count < 15)
            {
                Random random = new Random();

                int newRandom = random.Next(50);

                if (!newRow.Contains(newRandom))
                {
                    newRow.Add(newRandom);
                }
            }

            foreach (int index in newRow)
            {
                int columns = index / col;
                int rows = index % col;

                if (rows == 0 && index != 0)
                {
                    columns--;
                    rows = col;
                }
                else
                {
                    rows++;
                }

                gameField[columns, rows - 1] = '*';
            }

            return gameField;
        }

        private static void CalculatingInStepedFields(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char emptyFields = Place(field, i, j);
                        field[i, j] = emptyFields;
                    }
                }
            }
        }

        private static char Place(char[,] r, int rr, int rrr)
        {
            int movesCounter = 0;
            int row = r.GetLength(0);
            int col = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    movesCounter++;
                }
            }

            if (rr + 1 < row)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    movesCounter++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    movesCounter++;
                }
            }

            if (rrr + 1 < col)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    movesCounter++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    movesCounter++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < col))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    movesCounter++;
                }
            }

            if ((rr + 1 < row) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    movesCounter++;
                }
            }

            if ((rr + 1 < row) && (rrr + 1 < col))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    movesCounter++;
                }
            }

            return char.Parse(movesCounter.ToString());
        }
    }
}