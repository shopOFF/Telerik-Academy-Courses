using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MergeSort
{
    static void Main()
    {
        List<int> listToSort = new List<int>();
        int num = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            listToSort.Add(num);
        }
        listToSort.Sort();
        foreach (var item in listToSort)
        {
            Console.WriteLine(item);
        }
    }
}

