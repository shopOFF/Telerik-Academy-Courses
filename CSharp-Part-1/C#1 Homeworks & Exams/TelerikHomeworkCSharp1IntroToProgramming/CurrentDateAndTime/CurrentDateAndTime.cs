using System;

class CurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);

        //Or it's the same
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
    }
}
