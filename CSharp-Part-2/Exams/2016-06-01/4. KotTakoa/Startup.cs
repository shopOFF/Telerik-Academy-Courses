namespace KotTakoa
{
    using System;
    using System.Linq;
    using System.Text;

    class Startup
    {
        // delete all spaces around those characters
        static char[] NoSpaceAround = ".<>+=/*-{}();, '!&|?:[]%".ToCharArray();

        // all types that can be met in the code
        static string[] Types = { "int", "bool", "char", "string", "decimal", "var" };

        static void Solve()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new StringBuilder();

            var lastType = string.Empty;

            bool isInMultiLineComment = false;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Trim();

                // this will hold the trimmed line
                var noSpaces = new StringBuilder();

                // some variables to manage states
                var last = '\0';
                bool isInString = false;

                foreach (var symbol in line)
                {
                    if (isInMultiLineComment)
                    {
                        // if at multiline comment end
                        if (last == '*' && symbol == '/')
                        {
                            isInMultiLineComment = false;
                            last = result[result.Length - 1];
                        }
                        else
                        {
                            last = symbol;
                        }

                        // don't append symbols
                        continue;
                    }

                    // keep track of whether we're in a string literal
                    if (symbol == '"' && last != '\\')
                    {
                        isInString = !isInString;
                    }

                    // if no space around the symbol - kot takoa :D
                    if (NoSpaceAround.Contains(symbol) && last == ' ' && !isInString)
                    {
                        noSpaces[noSpaces.Length - 1] = symbol;
                    }
                    else if (!NoSpaceAround.Contains(last) || symbol != ' ' || isInString)
                    {
                        noSpaces.Append(symbol);
                    }

                    // track begginings of multiline comments
                    if (last == '/' && symbol == '*' && !isInString)
                    {
                        isInMultiLineComment = true;
                        noSpaces.Remove(noSpaces.Length - 2, 2);
                    }

                    // track begginings of single line comments
                    if (last == '/' && symbol == '/' && !isInString)
                    {
                        noSpaces.Remove(noSpaces.Length - 2, 2);
                        break;
                    }

                    // store the last symbol
                    last = noSpaces.Length > 0 ? noSpaces[noSpaces.Length - 1] : result[result.Length - 1];
                }

                var clearedLine = noSpaces.ToString();

                // type declaration minification
                var splitCleared = clearedLine.Split(' ');

                // if a type declaration
                if (Types.Contains(splitCleared[0]))
                {
                    // if the current type matches the last and is not var
                    if (lastType == splitCleared[0] && lastType != "var")
                    {
                        // replace ; with ,
                        result[result.Length - 1] = ',';
                        // remove the type keyword with the space after it
                        clearedLine = clearedLine.Remove(0, splitCleared[0].Length + 1);
                    }

                    lastType = splitCleared[0];
                }

                // append the resulting line
                result.Append(clearedLine);
            }

            Console.WriteLine(result);
        }

        static void Main()
        {
            Solve();
        }
    }
}
