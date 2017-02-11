using System;
using System.Diagnostics;

class SecretMessage
{
    static void Main()
    {
        string hiddenMessage = "";

        string str = Console.ReadLine();
        int lineNum = 0;
        while (str != "end")
        {
            int strt = int.Parse(str);
            int end = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            lineNum++;

            // start and end can be negative
            strt = strt >= 0 ? strt : line.Length + strt;
            end = end >= 0 ? end : line.Length + end;
                        
            // if odd/even line
            int step = lineNum % 2 == 1 ? 3 : 4;
            for (int i = strt; i <= end; i += step)
            {
                hiddenMessage += line[i];
                // Console.Write(line[i]); // alternative solution
            }

            str = Console.ReadLine();
        }

        Console.WriteLine(hiddenMessage);
    }
}