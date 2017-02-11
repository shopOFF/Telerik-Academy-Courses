namespace _MobilePhonePractice
{
    using System;

    public class MobilePhoneStartUp
    {
        static void Main()
        {
            var gsmTest = new GSMTest();   //Task 7 - GSM Test Class info
            gsmTest.DisplayGsmInfo();

            var call = new Call(DateTime.Now, "0899-10-4645", 333);  // adding a new call
            Console.WriteLine(call.ToString());

            var test = new GSMCallHistoryTest();         // Print Call History
            test.TestingFunctionality();
        }
    }
}