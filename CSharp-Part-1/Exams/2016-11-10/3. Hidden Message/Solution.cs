using System;
using System.Diagnostics;

class HiddenMessage
{
    static void Main()
    {
        string hiddenMessage = "";

        string s = Console.ReadLine();
        while (s != "end")
        {
            int ind = int.Parse(s);
            int step = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            if (ind < 0)
            {
                ind = line.Length + ind;
            }

            for (int i = ind; i < line.Length && i >= 0; i += step)
            {
                // hiddenMessage += line[i];
                Console.Write(line[i]); // alternative solution
            }

            s = Console.ReadLine();
        }

        Console.WriteLine(hiddenMessage);
    }
}