using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3SortIntsInIncOrder
{
    public class StartUp
    {
        internal static List<int> ReadingConsoleInput(string input)
        {
            var listOfNumbers = new List<int>();
            bool isNumeric;
            int correctIntegerNumber;

            while (input != string.Empty)
            {
                if (isNumeric = int.TryParse(input, out correctIntegerNumber) &&
                    (correctIntegerNumber > int.MinValue && correctIntegerNumber < int.MaxValue))
                {
                    listOfNumbers.Add(correctIntegerNumber);
                }
                else
                {
                    Console.WriteLine("You must enter a integer number");
                }

                input = Console.ReadLine();
            }

            return listOfNumbers;
        }
        public static void Main()
        {
            Console.WriteLine("Please enter positive integer numbers, each on a separate line!\nTo sort the numbers in increasing order double click Enter!");

            var listOfNumbers = ReadingConsoleInput(Console.ReadLine());
            var sortedNumbersInIncreasingOrder = listOfNumbers.OrderBy(n => n).ToList();

            Console.WriteLine("The sorted numbers in increasing order are: {0}",string.Join(", ", sortedNumbersInIncreasingOrder));
        }
    }
}
