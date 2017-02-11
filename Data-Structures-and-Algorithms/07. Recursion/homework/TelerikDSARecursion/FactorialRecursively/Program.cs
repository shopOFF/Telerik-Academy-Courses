using System;

namespace FactorialRecursively
{
    public class Program
    {
        private static int number;
        private static double factorial;

        public static double Factorial(int number)
        {
            if (number == 0)
            {
                factorial = 1;
                return factorial;
            }

            factorial = number * (Factorial(number - 1));
            return factorial;
        }

        public static void Main()
        {
            Console.WriteLine("Please enter a number:");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial of {0} is = {1}", number, Factorial(number));
        }
    }
}
