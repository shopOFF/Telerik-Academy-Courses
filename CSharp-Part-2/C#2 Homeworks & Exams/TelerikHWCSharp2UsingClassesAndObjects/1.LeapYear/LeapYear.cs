using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYear
{
    static void CheckForALeapYear(int year)
    {
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        CheckForALeapYear(year);
    }
}