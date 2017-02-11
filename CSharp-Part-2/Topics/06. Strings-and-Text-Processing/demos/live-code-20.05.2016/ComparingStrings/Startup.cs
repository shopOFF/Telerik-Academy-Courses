namespace ComparingStrings
{
    using System;

    class Startup
    {
        // compares two strings lexicographically, optionally ignoring the case
        static string[] OrderLexicographically(string left, string right, bool ignoreCase = true)
        {
            // stupid solution
            if (ignoreCase)
            {
                left = left.ToLower();
                right = right.ToLower();
            }

            var result = new string[2];

            int length = Math.Min(left.Length, right.Length);

            for (int i = 0; i < length; i++)
            {
                // for ignore case, it would be best to ingore the case here, not create two new strings in the beggining
                if (left[i] < right[i])
                {
                    result[0] = left;
                    result[1] = right;
                    return result;
                }
                else if (left[i] > right[i])
                {
                    result[0] = right;
                    result[1] = left;
                    return result;
                }
            }

            // if the program reaches this point of execution, no difference has been found between the string thus far

            result[0] = left.Length < right.Length ? left : right;
            result[1] = left.Length > right.Length ? left : right;

            return result;
        }
        static void Main()
        {
            string s1 = "aaaaaaaaa";
            string s2 = "Abb";

            string str1 = "aaabcd";
            string str2 = "aacb";

            string str3 = "aab";
            string str4 = "aabggg";

            //var result = OrderLexicographically(s1, s2, false);

            //Console.WriteLine(result[0] + " " + result[1]);

            Console.WriteLine(string.Compare(str2, str1, true));
        }
    }
}
