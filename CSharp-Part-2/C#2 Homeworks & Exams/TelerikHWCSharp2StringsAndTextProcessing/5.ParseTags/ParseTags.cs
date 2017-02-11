using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ParseTags
{
    private static string ParseUpcaseTags(string input, string openTag, string closeTag)
    {
        StringBuilder parsedText = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i + openTag.Length < input.Length && input.Substring(i, openTag.Length).Equals(openTag))
            {
                string textToAdd = input.Substring(
                    i + openTag.Length,
                    input.IndexOf(closeTag, i + openTag.Length) - i - closeTag.Length + 1);
                parsedText.Append(textToAdd.ToUpper());
                i = input.IndexOf(closeTag, i + openTag.Length) + closeTag.Length - 1;
            }
            else
            {
                parsedText.Append(input[i]);
            }
        }

        return parsedText.ToString();
    }
    static void Main(string[] args)
    {
        //We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
        string input = Console.ReadLine();
        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        Console.WriteLine(ParseUpcaseTags(input, openTag, closeTag));
    }
}
// vtori na4in :
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05_Parse_Tags_3
//{
//    class ParseTags3
//    {
//        // 100/ 100
//        static void Main()
//        {
//            var openTag = "upcase";
//            var closeTag = "/upcase";

//            var toParse = Console
//                .ReadLine()
//                .Split(new char[] { '<', '>' })
//                .ToArray();

//            var output = new StringBuilder();
//            var toUpper = false;

//            foreach (var word in toParse)
//            {
//                if (word == openTag)
//                {
//                    toUpper = true;
//                    continue;
//                }

//                if (word == closeTag)
//                {
//                    toUpper = false;
//                    continue;
//                }

//                if (toUpper)
//                {
//                    output.Append(word.ToUpper());
//                }
//                else
//                {
//                    output.Append(word);
//                }
//            }

//            Console.WriteLine(output);
//        }
//    }
//}