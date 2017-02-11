namespace Timer
{
    using System;

    public class TimeStartUp
    {
        public static void Main()
        {

            Timer timer = new Timer(5);

            timer.SomeMethods += FirstTestMethod;
            timer.SomeMethods += SecondTestMethod;
            timer.ExecuteMethods();
        }

        public static void FirstTestMethod()
        {
            Console.WriteLine("Hello i am the first method, i will show up every now and then  :/");
        }

        public static void SecondTestMethod()
        {
            Console.WriteLine("Hello i am the second method, i will show up every now and then :\\");
        }
    }
}
