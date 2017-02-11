namespace Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        private int timeInterval;

        public delegate void TimerDlg();

        public TimerDlg SomeMethods { get; set; }

        public int TimeInterval
        {
            get { return this.timeInterval; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Interval must be >= 1");
                }

                this.timeInterval = value;
            }
        }

        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Thread.Sleep(this.timeInterval * 1000);
            }
        }
    }
}
