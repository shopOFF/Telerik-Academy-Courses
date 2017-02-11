using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        // ako iskame da znaem vsi4ki elementi po kolko pati se povtarqt
        //Dictionary<int, int> counts = array.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        //foreach (var item in counts)
        //{
        //    Console.WriteLine("{0} ({1} times)", item.Key, item.Value);

        //}
        var cnt = new Dictionary<int, int>();
        foreach (int value in array)
        {
            if (cnt.ContainsKey(value))
            {
                cnt[value]++;
            }
            else
            {
                cnt.Add(value, 1);
            }
        }
        int mostCommonValue = 0;
        int highestCount = 0;
        foreach (KeyValuePair<int, int> pair in cnt)
        {
            if (pair.Value > highestCount)
            {
                mostCommonValue = pair.Key;
                highestCount = pair.Value;
            }
        }
        Console.WriteLine("{0} ({1} times)", mostCommonValue,highestCount);
    }
}