namespace ExtractComments
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Startup
    {
        // extract the starting indices of all double slash comments
        static List<int> FindDoubleSlashCommentStart(string code)
        {
            var indices = new List<int>();

            int nextCommentStart = code.IndexOf("//");
            int nextNewlineIndex = 0;

            while (nextNewlineIndex != -1 && nextCommentStart != -1)
            {
                indices.Add(nextCommentStart);

                nextNewlineIndex = code.IndexOf(Environment.NewLine, nextCommentStart);
                indices.Add(nextNewlineIndex);

                nextCommentStart = code.IndexOf("//", nextNewlineIndex + 1);
            }

            return indices;
        }

        // extract comments using a StringBuilder and easy finite automata approach
        static string ExtractComments(string code)
        {
            var result = new StringBuilder();

            bool isInSingleLineComment = false;
            bool isInMultiLineComment = false;
            char last = ' ';

            foreach (char symbol in code)
            {
                if (isInSingleLineComment || isInMultiLineComment)
                {
                    result.Append(symbol);
                }

                if (last == '/' && symbol == '/' && !isInMultiLineComment)
                {
                    result.Append("//");
                    isInSingleLineComment = true;
                }

                if (last == '/' && symbol == '*' && !isInSingleLineComment)
                {
                    result.Append("/*");
                    isInMultiLineComment = true;
                }

                if (last == '\r' && symbol == '\n')
                {
                    if (isInMultiLineComment || isInMultiLineComment)
                    {
                        result.Append("\r\n");
                    }
                    isInSingleLineComment = false;
                }

                if (last == '*' && symbol == '/')
                {
                    result.Append("\r\n");
                    isInMultiLineComment = false;
                }

                last = symbol;
            }

            return result.ToString();
        }

        static void Main()
        {
            var code = @"/* just a meaningless comment */
namespace ExtractComments
{
    // my usings are here
    using System;

    // penka e //yaka macka
    class Startup
    {
        // otivam na kafe s ivan
        static void Main()
        {
            var code = ""; /* koito go e pisal tozi kod,
             sdflkjdsjfldsfjlkdsfjdslkfjdlkf
             ne e dobre */
        }
        // javascript
    }
}
// za cvqt
";
            // use nice automata approach
            Console.WriteLine(ExtractComments(code));

            // clunky substring approach

            //var indices = FindDoubleSlashCommentStart(code);

            //for (int i = 0; i < indices.Count; i += 2)
            //{
            //    int start = indices[i];
            //    int end = indices[i + 1];
            //    var comment = code.Substring(start, end - start);

            //    Console.WriteLine(comment);
            //}

            // Console.WriteLine(string.Join(", ", indices));
        }
        // javascript
    }
}