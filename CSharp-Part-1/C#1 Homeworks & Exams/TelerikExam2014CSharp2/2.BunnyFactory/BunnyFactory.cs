using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BunnyFactory
{
    static void Main()
    {
        List<string> arr = new List<string>();
        string n = "";
        for (int i = 0; i < 100; i++)
        {
            n = Console.ReadLine();
            if (n == "END")
            {
                break;
            }
            arr.Add(n);
        }
        List<int> arrToInt = arr.Select(int.Parse).ToList();
    }
}

