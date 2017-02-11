using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string text = Console.ReadLine();
        string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
        Console.WriteLine(parsedHTML);
    }
}

//re6enie bez regex

//using System;
//using System.Text;
 
//class ReplaceTags
//{
//    static void Main()
//    {
 
//        // <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 
//        string text = Console.ReadLine();
//        var sb = new StringBuilder();
 
//        for (int i = 0; i < text.Length; i++)
//        {
//            if (i < text.Length - 9 && text[i] == '<' && text.Substring(i, 9) == "<a href=\"")
//            {
//                var endOfTag = text.IndexOf("<", i + 9);
//                var endOfUrl = text.IndexOf("\">", i + 9);
 
//                var url = text.Substring(i + 9, endOfUrl - i - 9);
//                var body = text.Substring(endOfUrl + 2, endOfTag - endOfUrl - 2);
 
//                sb.Append(string.Format("[{0}]({1})", body, url));
 
//                i = endOfTag + 3;
//            }
//            else
//            {
//                sb.Append(text[i]);
//            }
 
//        }
 
//        Console.WriteLine(sb.ToString().Trim());
//    }
//}