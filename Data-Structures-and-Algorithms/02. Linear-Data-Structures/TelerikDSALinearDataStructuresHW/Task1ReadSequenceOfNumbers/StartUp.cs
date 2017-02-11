using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task1ReadSequenceOfNumbers
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
                if (isNumeric = int.TryParse(input, out correctIntegerNumber) && correctIntegerNumber > 0)
                {
                    listOfNumbers.Add(correctIntegerNumber);
                }
                else
                {
                    Console.WriteLine("You must enter a positive integer number");
                }

                input = Console.ReadLine();
            }

            return listOfNumbers;
        }
        internal static BigInteger FindSumOfNumbers(List<int> listOfNumbers)
        {
            var sumOfNumbers = 0;
            sumOfNumbers = listOfNumbers.Sum();

            return sumOfNumbers;
        }

        internal static double FindAvarageOfNumbers(List<int> listOfNumbers)
        {
            var avagrageOfNumbers = 0d;

            if (listOfNumbers.Count > 0)
            {
                avagrageOfNumbers = listOfNumbers.Average();
            }

            return avagrageOfNumbers;
        }

        public static void Main()
        {
            Console.WriteLine("Please enter positive integer numbers, each on a separate line!\nTo calculate the sum and avarage of the numbers double click Enter!");

            var listOfNumbers = ReadingConsoleInput(Console.ReadLine());
            var sumOfNumbers = FindSumOfNumbers(listOfNumbers);
            var avagrageOfNumbers = FindAvarageOfNumbers(listOfNumbers);

            Console.WriteLine("The numbers in the list are: {0}", string.Join(", ", listOfNumbers));
            Console.WriteLine("The sum of the numbers in the list is: {0}", sumOfNumbers);
            Console.WriteLine("The avarage of the numbers in the list is: {0}", avagrageOfNumbers);
        }
    }
}
