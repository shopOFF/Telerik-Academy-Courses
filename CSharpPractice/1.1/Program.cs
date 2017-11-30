using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            if (input % 10 == 0)
            {
                CheckIf3DigitIsZero(input);
            }
            else if (input % 10 > 0 && input % 10 <= 5)
            {
                CheckIf3DigitIsBetween1And5(input);
            }
            else
            {
                CheckIf3DigitIsLargerThan5(input);
            }
        }
        private static void CheckIf3DigitIsBetween1And5(int input)  // second way
        {
            double fistNum = /*(input / 100) % 10;*/ Convert.ToDouble(input.ToString().Substring(0, 1));
            double secondNum = /*(input / 10) % 10;*/ Convert.ToDouble(input.ToString().Substring(1, 1));
            var thirdDigit = /*input % 10;*/ Convert.ToDouble(input.ToString().Substring(2, 1));
            var product = (fistNum * secondNum) / thirdDigit;

            Console.WriteLine(string.Format("{0:F2}", product));
        }

        private static void CheckIf3DigitIsLargerThan5(int input)
        {
            double fistNum = (input / 100) % 10;
            double secondNum = (input / 10) % 10;
            var thirdDigit = input % 10;
            var product = (fistNum + secondNum) * thirdDigit;

            Console.WriteLine(string.Format("{0:F2}", product));
        }

        public static void CheckIf3DigitIsZero(int input)
        {
            var fistNum = (input / 100) % 10;
            var secondNum = (input / 10) % 10;
            var product = fistNum * secondNum;

            Console.WriteLine(string.Format("{0:F2}", product));
        }
    }
}
