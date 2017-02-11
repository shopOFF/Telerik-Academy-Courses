using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareCharArrays
{
    static void Main()
    {
        string firstArr = Console.ReadLine();
        string secondArr = Console.ReadLine();
        int counter = 0;
        if (firstArr.Length > secondArr.Length)
        {
            Console.WriteLine(">");
        }
        else if (firstArr.Length < secondArr.Length)
        {
            Console.WriteLine("<");
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counter++;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine('<');
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine('>');
                    break;
                }
            }
            if (counter == firstArr.Length)
            {
                Console.WriteLine('=');
            }
        }
    }
}
