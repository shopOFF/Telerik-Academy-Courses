namespace ConcatVsAppend
{
    using System;
    using System.Diagnostics;
    using System.Text;

    class Startup
    {
        static void ComparePerformance()
        {
            var timer = new Stopwatch();

            const int Repeat = 10000000;

            string str = string.Empty;

            timer.Start();
            for (int i = 0; i < Repeat; i++)
            {
                str += "a";
            }
            timer.Stop();

            Console.WriteLine(timer.Elapsed + " Concat");

            var builder = new StringBuilder();

            timer.Restart();
            for (int i = 0; i < Repeat; i++)
            {
                builder.Append("a");
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " Builder");
        }

        static void Main()
        {
            ComparePerformance();
        }
    }
}
