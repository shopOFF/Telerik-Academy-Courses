using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2ReverseIntsWithStack
{
    public class StartUp
    {
        internal static Stack<int> ReadingConsoleInput(string input)
        {
            var stackOfNumbers = new Stack<int>();
            bool isNumeric;
            int correctIntegerNumber;

            while (input != string.Empty)
            {
                if (isNumeric = int.TryParse(input, out correctIntegerNumber) &&
                    (correctIntegerNumber > int.MinValue && correctIntegerNumber < int.MaxValue))
                {
                    stackOfNumbers.Push(correctIntegerNumber);
                }
                else
                {
                    Console.WriteLine("You must enter a integer number");
                }

                input = Console.ReadLine();
            }

            return stackOfNumbers;
        }
        public static void Main()
        {
            Console.WriteLine("Please enter positive integer numbers, each on a separate line!\nTo reverse the order and print the numbers in the stack double click Enter!");
            var stackOfNumbers = ReadingConsoleInput(Console.ReadLine());

            Console.WriteLine("The original order in the stack is: {0}", string.Join(", ", stackOfNumbers));
            Console.WriteLine("The reversed order in the stack is: {0}", string.Join(", ", stackOfNumbers.Reverse()));
        }
    }
}
