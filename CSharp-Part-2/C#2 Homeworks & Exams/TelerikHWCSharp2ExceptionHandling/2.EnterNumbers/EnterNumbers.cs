using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnterNumbers
{
    static string ReadNumber(int start, int end, List<int> numbersList)
    {
        numbersList.Insert(0, start);
        numbersList.Insert(11, end);
        for (int i = 0; i < numbersList.Count - 1; i++)
        {
            if (numbersList[i] >= numbersList[i + 1])
            {
                return "Exception";
            }
        }
        return string.Join(" < ", numbersList);
    }
    static void Main()
    {
        List<int> numbersList = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbersList.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(ReadNumber(1, 100, numbersList)); 
    }
}