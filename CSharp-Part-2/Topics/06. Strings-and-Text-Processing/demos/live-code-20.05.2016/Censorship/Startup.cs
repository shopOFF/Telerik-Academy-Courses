namespace Censorship
{
    using System;

    class Startup
    {
        static void Main()
        {
            // obscure a set of given words from an article
            // real life example: remove swearword from a forum post

            var censorshipSymbols = "@#!?+#^%!~!!!!1!@#!?+#^%!~!!!!1!";

            var swearWords = new string[] 
            {
                "bau",
                "mqu",
                "coo",
                "pur",
                "FAQ",
                "batal",
                "programist",
                "kraen avtomat",
                "rekursiq"
            };

            var forumPost = @"Dokato si vodeh lekciqta reshihme da coo mqu kotkata pravq
bau ili mqu ili cur i pur ako e na skarata
workshop po rekursiq - iok
read FAQ before asking dumb question
programist program batal battle ships cookie";

            foreach (var swear in swearWords)
            {
                forumPost = forumPost.Replace(swear, censorshipSymbols.Substring(0, swear.Length));
            }

            Console.WriteLine(forumPost);
        }
    }
}
