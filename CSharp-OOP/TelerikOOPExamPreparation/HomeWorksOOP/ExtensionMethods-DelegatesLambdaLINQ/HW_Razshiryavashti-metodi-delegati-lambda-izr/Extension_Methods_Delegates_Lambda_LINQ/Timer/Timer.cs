using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Timer
    {
        private readonly int seconds;
        public delegate void PrintSomething();

        public Timer(int seconds)
        {
            this.seconds = seconds;
        }

        public void InvokeDelegate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var myDelegate = new PrintSomething(PrintTime);

            while (true)
            {
                if (stopwatch.Elapsed.Seconds != this.seconds)
                {
                    continue;
                }

                myDelegate.Invoke();
                stopwatch.Restart();
            }
        }

        private static void PrintTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
