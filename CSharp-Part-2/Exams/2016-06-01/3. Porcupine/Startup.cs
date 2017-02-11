namespace Porcupine
{
    using System;

    class Startup
    {
        static void Main()
        {
            int basecols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            string[] xy = Console.ReadLine().Split(' ');
            int porX = int.Parse(xy[0]);
            int porY = int.Parse(xy[1]);

            xy = Console.ReadLine().Split(' ');
            int rabbitX = int.Parse(xy[0]);
            int rabbitY = int.Parse(xy[1]);

            int[][] forest = new int[rows][];
            for (int i = 0; i < rows; ++i)
            {
                forest[i] = new int[(i < rows / 2 ? i + 1 : rows - i) * basecols];
                for (int j = 0; j < forest[i].Length; ++j)
                {
                    forest[i][j] = (i + 1) * (j + 1);
                }
            }

            long porPoints = forest[porX][porY];
            long rabbitPoints = forest[rabbitX][rabbitY];
            forest[porX][porY] = 0;
            forest[rabbitX][rabbitY] = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                char direction = line[2];
                int steps = int.Parse(line.Substring(4));

                if (line[0] == 'P')
                {
                    int newX = porX;
                    int newY = porY;

                    for (int i = 0; i < steps; ++i)
                    {
                        switch (direction)
                        {
                            case 'L':
                                newY = (porY + forest[porX].Length - 1) % forest[porX].Length;
                                break;
                            case 'R':
                                newY = (porY + 1) % forest[porX].Length;
                                break;
                            case 'T':
                                if (porX > 0 && porY < forest[porX - 1].Length)
                                {
                                    newX = porX - 1;
                                }
                                else
                                {
                                    newX = forest.Length - 1 - porX;
                                }
                                break;
                            case 'B':
                                if (porX + 1 < forest.Length && porY < forest[porX + 1].Length)
                                {
                                    newX = porX + 1;
                                }
                                else
                                {
                                    newX = forest.Length - 1 - porX;
                                }
                                break;
                        }

                        if (newX == rabbitX && newY == rabbitY)
                        {
                            break;
                        }

                        porX = newX;
                        porY = newY;

                        porPoints += forest[porX][porY];
                        forest[porX][porY] = 0;
                    }
                }
                else
                {
                    int newX = rabbitX;
                    int newY = rabbitY;

                    for (int i = 0; i < steps; ++i)
                    {
                        switch (direction)
                        {
                            case 'L':
                                newY = (rabbitY + forest[rabbitX].Length - 1) % forest[rabbitX].Length;
                                break;
                            case 'R':
                                newY = (rabbitY + 1) % forest[rabbitX].Length;
                                break;
                            case 'T':
                                if (rabbitX > 0 && rabbitY < forest[rabbitX - 1].Length)
                                {
                                    newX = rabbitX - 1;
                                }
                                else
                                {
                                    newX = forest.Length - 1 - rabbitX;
                                }
                                break;
                            case 'B':
                                if (rabbitX + 1 < forest.Length && rabbitY < forest[rabbitX + 1].Length)
                                {
                                    newX = rabbitX + 1;
                                }
                                else
                                {
                                    newX = forest.Length - 1 - rabbitX;
                                }
                                break;
                        }

                        if (i + 1 == steps && newX == porX && newY == porY)
                        {
                            break;
                        }

                        rabbitX = newX;
                        rabbitY = newY;
                    }

                    rabbitPoints += forest[rabbitX][rabbitY];
                    forest[rabbitX][rabbitY] = 0;
                }
            }

            if (rabbitPoints > porPoints)
            {
                Console.WriteLine("The rabbit WON with {0} points. The porcupine scored {1} points only.", rabbitPoints, porPoints);
            }
            else if (rabbitPoints < porPoints)
            {
                Console.WriteLine("The porcupine destroyed the rabbit with {1} points. The rabbit must work harder. He scored {0} points only.", rabbitPoints, porPoints);
            }
            else
            {
                Console.WriteLine("Both units scored {0} points. Maybe we should play again?", porPoints);
            }
        }
    }

}