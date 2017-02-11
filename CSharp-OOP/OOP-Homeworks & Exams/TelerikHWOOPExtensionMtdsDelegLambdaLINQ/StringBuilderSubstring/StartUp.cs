namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    using Extensions;
    public class StartUp
    {
         public static void Main()
        {
            var test = new StringBuilder("May the Force be with you!");
            Console.WriteLine(test.Substring(3,4));
            Console.WriteLine(test.Substring(4, 17));
        }
    }
}
