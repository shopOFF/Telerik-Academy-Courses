using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static void Main()
    {
        List<int> numList = new List<int>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numList.Add(num);
        }
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(numList.IndexOf(x));
    }
}

