using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();
        text = text.Replace("\\", string.Empty);
        Console.WriteLine(text.PadRight(20, '*'));
    }
}
// vtori na4in:
        //string text = Console.ReadLine();

        //StringBuilder textBuilder = new StringBuilder();
        //text = text.Replace("\\", string.Empty);
        //textBuilder.Append(text);
        //while (textBuilder.Length < 20)
        //{
        //    textBuilder.Append('*');
        //}
        //Console.WriteLine(textBuilder.ToString());