namespace _MobilePhonePractice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSMCallHistoryTest         // Task 12
    {
        public GSM testGsm = new GSM("Note 3", "Samsung");
        private const decimal PricePerMinute = 0.37m;

        public void TestingFunctionality()
        {                    // Adding some calls
            testGsm.AddCall(new Call(DateTime.Now, "0899-10-4645", 333)); // it's printed already, so we will skip it, if we have to print the call history
            testGsm.AddCall(new Call(new DateTime(2013, 09, 24, 22, 05, 30), "0887 10 45 66", 1550));
            testGsm.AddCall(new Call(new DateTime(2014, 07, 13, 22, 03, 22), "0888 88 45 88", 150));
            testGsm.AddCall(new Call(new DateTime(2015, 06, 11, 13, 23, 15), "0887 11 11 66", 50));
            testGsm.AddCall(new Call(new DateTime(2016, 03, 05, 12, 01, 05), "0899 55 66 99", 950));

            for (int i = 1; i < testGsm.CallHistory.Count; i++)
            {
                Console.WriteLine(string.Join("\n", testGsm.CallHistory[i])); // skipping the first element
            }

            Console.WriteLine("\n----------> The total price of all calls is: {0:F2} BGN <---------\n\n", testGsm.TotalPriceOfCalls(PricePerMinute));

            // Remove the longest call from the history and calculate the total price again.
            Call longestCall = testGsm.CallHistory.OrderByDescending(x => x.CallDuration).First();
            testGsm.DeleteCall(longestCall);
            
            Console.WriteLine("\n----------> The total price after removing the longest call is: {0:F2} BGN <---------\n\n", testGsm.TotalPriceOfCalls(PricePerMinute));

            // Finally clear the call history and print it.
            testGsm.ClearCallHistory();
            Console.WriteLine("\n----------> Call history has been cleared!!! <---------\n\n");
        }

    }
}
