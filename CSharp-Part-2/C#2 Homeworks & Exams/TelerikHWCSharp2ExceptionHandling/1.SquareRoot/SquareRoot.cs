using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareRoot
{
    static void Main()
    {
        string number = Console.ReadLine();

        try
        {
            double numberToDouble = Math.Sqrt(Convert.ToDouble(number));

            if (double.IsNaN(numberToDouble))
            {
                throw new FormatException();
            }

            Console.WriteLine("{0:F3}", numberToDouble);
            Console.WriteLine("Good bye");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
            Console.WriteLine("Good bye");
        }
    }
}