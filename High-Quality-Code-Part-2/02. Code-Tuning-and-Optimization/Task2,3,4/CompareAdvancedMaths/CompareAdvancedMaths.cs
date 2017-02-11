namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompareAdvancedMaths
    {
        private static void DisplayExecutionTime(Action action)
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
            Console.WriteLine("Square root:");
            Console.Write("Float: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    float number = 5.0f;
                    Math.Sqrt(number);
                }
            });

            Console.Write("Double: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    double number = 5.0;
                    Math.Sqrt(number);
                }
            });

            Console.Write("Decimal: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    decimal number = 5.0m;
                    Math.Sqrt((double)number);
                }
            });

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Natural logarithm:");
            Console.Write("Float: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    float number = 5.0f;
                    Math.Log(number);
                }
            });

            Console.Write("Double: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    double number = 5.0;
                    Math.Log(number);
                }
            });

            Console.Write("Decimal: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    decimal number = 5.0m;
                    Math.Log((double)number);
                }
            });

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sinus:");
            Console.Write("Float: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    float number = 5.0f;
                    Math.Sin(number);
                }
            });

            Console.Write("Double: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    double number = 5.0;
                    Math.Sin(number);
                }
            });

            Console.Write("Decimal: ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < numberOfOperations; i++)
                {
                    decimal number = 5.0m;
                    Math.Sin((double)number);
                }
            });
        }
    }
}
