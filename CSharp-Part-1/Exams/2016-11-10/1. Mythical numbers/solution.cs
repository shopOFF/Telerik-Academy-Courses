using System;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static void Main(string[] args)
        {
          int number = int.Parse(Console.ReadLine());

          float digit1 = number / 100 % 10;
          float digit2 = number / 10 % 10;
          float digit3 = number / 1 % 10;

          float result;

          if (digit3 == 0)
          {
              result = digit1 * digit2;
          }
          else if (0 < digit3 && digit3 <= 5)
          {
              result = (digit1 * digit2) / digit3;
          }
          else
          {
              result = (digit1 + digit2) * digit3;
          }

          Console.WriteLine("{0:F2}", result);
        }
    }
}
