namespace _03.Patterns
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            long maxsum = long.MinValue;
            bool found = false;

            for (int i = 0; i + 2 < n; i++)
            {
                for (int j = 0; j + 4 < n; j++)
                {
                    if((matrix[i, j] + 1 == matrix[i, j + 1])
                        && (matrix[i, j] + 2 == matrix[i, j + 2])
                        && (matrix[i, j] + 3 == matrix[i + 1, j + 2])
                        && (matrix[i, j] + 4 == matrix[i + 2, j + 2])
                        && (matrix[i, j] + 5 == matrix[i + 2, j + 3])
                        && (matrix[i, j] + 6 == matrix[i + 2, j + 4]))
                    {
                        found = true;

                        long sum = 7L * matrix[i, j] + 21;
                         // pattern is consisted of 7 cells
                         // 0 + 1 + 2 + 3 + 4 + 5 + 6 = 21
                        
                        if(maxsum < sum)
                        {
                            maxsum = sum;
                        }
                    }
                }
            }

            if(!found)
            {
				long sum = 0;
				for (int i = 0; i < n; i++)
				{
					sum += matrix[i, i];
				}
				Console.WriteLine("NO {0}", sum);
            }
            else
			{
				Console.WriteLine("YES {0}", maxsum);
			}
		}
	}
}
