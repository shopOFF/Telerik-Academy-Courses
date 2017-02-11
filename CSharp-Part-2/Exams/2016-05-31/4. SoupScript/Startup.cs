namespace SoupScript
{
    using System;
    using System.Linq;
    using System.Text;

    class Startup
    {
        static char[] noSpaceBefore = { '.', '(', ')', ';', ',' };

        static char[] noSpaceAfter = { '.', '(', ' ', '\n', '!', ';' };

        static char[] spaceAround = { '+', '-', '<', '>', '=', '*' };

        const int indentSize = 4;

        // whitespace formatting method
        static string ReplaceWhitespaces(string soup)
        {
            var result = new StringBuilder();

            var last = ' ';
            var scopeDepth = 0;
            var isInComment = false;
            var isInString = false;

            foreach (var symbol in soup)
            {
                // if in comment or string, don't format anything
                if (isInComment || isInString)
                {
                    last = symbol;
                    result.Append(symbol);

                    isInComment = isInComment && symbol != '\r' && symbol != '\n';
                    isInString = isInString && symbol != '\'';

                    continue;
                }

                // track scopes for indentation
                if (symbol == '{')
                {
                    scopeDepth++;

                    // put a whitespace between ) and {
                    if (result[result.Length - 1] != ' ')
                    {
                        result.Append(' ');
                    }
                }
                else if (symbol == '}')
                {
                    scopeDepth--;
                }

                // symbol appending logic
                if (noSpaceAfter.Contains(last) && symbol == ' ')
                {
                    continue;
                }
                else if (noSpaceBefore.Contains(symbol) && last == ' ')
                {
                    result[result.Length - 1] = symbol;
                }
                else
                {
                    // track comment and string starts
                    isInComment = symbol == '/' && last == '/';

                    isInString = symbol == '\'';

                    // apply indentation
                    if (last == '\n')
                    {
                        result.Append(new string(' ', indentSize * scopeDepth));
                    }

                    // handle operators
                    if (spaceAround.Contains(symbol))
                    {
                        if (last != ' ')
                        {
                            result.Append(' ');
                        }

                        result.Append(symbol + " ");
                    }
                    else
                    {
                        result.Append(symbol);
                    }
                }

                // track the last appended symbol
                last = result[result.Length - 1];
            }

            return result.ToString();
        }

        // coments formatting method
        static string FormatComments(string formattedSoup)
        {
            // get all lines
            var lines = formattedSoup.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // for every, extracts the comment(if exists) and if necessary, prepend it
            for (int i = 0; i < lines.Length; i++)
            {
                var codeAndComment = lines[i].Split(new[] { "//" }, StringSplitOptions.RemoveEmptyEntries);

                if (codeAndComment.Length != 2 || string.IsNullOrWhiteSpace(codeAndComment[0]))
                {
                    continue;
                }

                // if both code and comment exist in the current line
                var code = codeAndComment[0];
                var comment = codeAndComment[1];

                // compute the indentation for the comment
                var indent = 0;

                while (indent < code.Length && code[indent] == ' ')
                {
                    indent += indentSize;
                }

                // asseble the new line
                lines[i] = new string(' ', indent) + "//" + comment + Environment.NewLine + code.TrimEnd();
            }

            return string.Join(Environment.NewLine, lines);
        }

        static void Solve()
        {
            var n = int.Parse(Console.ReadLine());

            var soup = string.Join(Environment.NewLine, Enumerable.Range(0, n).Select(x => Console.ReadLine()));

            var whitespaceFormattedSoup = ReplaceWhitespaces(soup);
            var formattedSoup = FormatComments(whitespaceFormattedSoup);

            var splitByLines = formattedSoup.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in splitByLines)
            {
                // ignore empty lines
                if (!string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            Solve();
        }
    }
}
