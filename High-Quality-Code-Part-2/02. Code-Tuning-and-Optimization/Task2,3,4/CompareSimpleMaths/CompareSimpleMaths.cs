namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class CompareSimpleMaths
    {
        public static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Main()
        {
            int numberOfOperations = 10000000;

            Console.WriteLine("10 million operations completed for:");
            Console.WriteLine(new string('-', 50));
            Console.Write("Int add: ");
            DisplayExecutionTime(() =>
            {
                int result = 0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Long add: ");
            DisplayExecutionTime(() =>
            {
                long result = 0L;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Float add: ");
            DisplayExecutionTime(() =>
            {
                float result = 0.0f;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Double add: ");
            DisplayExecutionTime(() =>
            {
                double result = 0.0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Decimal add: ");
            DisplayExecutionTime(() =>
            {
                decimal result = 0.0m;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.WriteLine(new string('-', 50));
            Console.Write("Int subtract: ");
            DisplayExecutionTime(() =>
            {
                int result = 10000000;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result -= 1;
                }
            });

            Console.Write("Long subtract: ");
            DisplayExecutionTime(() =>
            {
                long result = 10000000L;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Float subtract: ");
            DisplayExecutionTime(() =>
            {
                float result = 10000000.0f;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Double subtract: ");
            DisplayExecutionTime(() =>
            {
                double result = 10000000.0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.Write("Decimal subtract: ");
            DisplayExecutionTime(() =>
            {
                decimal result = 10000000.0m;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result += 1;
                }
            });

            Console.WriteLine(new string('-', 50));
            Console.Write("Int increment: ");
            DisplayExecutionTime(() =>
            {
                int result = 0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result++;
                }
            });

            Console.Write("Long increment: ");
            DisplayExecutionTime(() =>
            {
                long result = 0L;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result++;
                }
            });

            Console.Write("Float increment: ");
            DisplayExecutionTime(() =>
            {
                float result = 0.0f;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result++;
                }
            });

            Console.Write("Double increment: ");
            DisplayExecutionTime(() =>
            {
                double result = 0.0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result++;
                }
            });

            Console.Write("Decimal increment: ");
            DisplayExecutionTime(() =>
            {
                decimal result = 0.0m;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result++;
                }
            });

            Console.WriteLine(new string('-', 50));
            Console.Write("Int multiply: ");
            DisplayExecutionTime(() =>
            {
                int result = 1;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result *= 1;
                }
            });

            Console.Write("Long multiply: ");
            DisplayExecutionTime(() =>
            {
                long result = 1L;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result *= 1;
                }
            });

            Console.Write("Float multiply: ");
            DisplayExecutionTime(() =>
            {
                float result = 1.0f;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result *= 1;
                }
            });

            Console.Write("Double multiply: ");
            DisplayExecutionTime(() =>
            {
                double result = 1.0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result *= 1;
                }
            });

            Console.Write("Decimal multiply: ");
            DisplayExecutionTime(() =>
            {
                decimal result = 1.0m;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result *= 1;
                }
            });

            Console.WriteLine(new string('-', 50));
            Console.Write("Int divide: ");
            DisplayExecutionTime(() =>
            {
                int result = 1;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result /= 1;
                }
            });

            Console.Write("Long divide: ");
            DisplayExecutionTime(() =>
            {
                long result = 1L;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result /= 1;
                }
            });

            Console.Write("Float divide: ");
            DisplayExecutionTime(() =>
            {
                float result = 1.0f;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result /= 1;
                }
            });

            Console.Write("Double divide: ");
            DisplayExecutionTime(() =>
            {
                double result = 1.0;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result /= 1;
                }
            });

            Console.Write("Decimal divide: ");
            DisplayExecutionTime(() =>
            {
                decimal result = 1.0m;
                for (int i = 0; i < numberOfOperations; i++)
                {
                    result /= 1;
                }
            });
        }
    }
}
