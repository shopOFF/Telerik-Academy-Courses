using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    // TODO: 60/100 точки в момента дава
    static string GetUnicodeRepresentation(string input)
    {
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            output.Append("\\u" + ((int)input[i]).ToString("X4"));
        }
        return output.ToString();
    }
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(GetUnicodeRepresentation(input));
    }
}