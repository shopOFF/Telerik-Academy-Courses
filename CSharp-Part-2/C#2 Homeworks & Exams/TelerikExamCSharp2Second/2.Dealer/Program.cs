using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numOfHands = int.Parse(Console.ReadLine());
        var numsList = new List<ulong>();
        List<string> deck = new List<string>() { "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
                                                   "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
                                                    "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
                                                     "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};

        var numInBin = string.Empty;
        var cardsPositions = new List<byte>();
        byte counter = 0;

        for (int i = 0; i < numOfHands; i++)
        {
            // numsList.Add(ulong.Parse(Console.ReadLine()));
            numInBin = (Convert.ToString(Int64.Parse(Console.ReadLine()), 2).PadLeft(64, '0'));

            for (int e = numInBin.Length - 1; e >= 0; e--)
            {
                if (numInBin[e] == '1')
                {
                    cardsPositions.Add(counter);
                }

                counter++;
            }

            counter = 0;
        }

        var numberGroups = cardsPositions.OrderBy(p => p).GroupBy(i => i);
        var numCounter = 0;
        var positions = new List<byte>();

        foreach (var grp in numberGroups)
        {
           // Console.WriteLine("{0}->{1}", grp.Key, grp.Count());
            if (numCounter != grp.Key)
            {
                Console.WriteLine("Wa wa!");
                Console.WriteLine(deck[grp.Key]);
                return;
            }
            else
            {
                positions.Add(grp.Count()));
                
            }
           
            numCounter++;
            // Console.WriteLine(grp.Count());
        }
        foreach (var item in positions)
        {
            Console.WriteLine("Full deck");
            Console.WriteLine(deck[item]);
        }
       

    }
}
