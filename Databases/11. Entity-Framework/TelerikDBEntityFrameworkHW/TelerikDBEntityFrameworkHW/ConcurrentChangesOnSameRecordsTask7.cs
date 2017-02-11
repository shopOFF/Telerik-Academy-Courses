using System;
using System.Linq;

namespace TelerikDBEntityFrameworkHW
{
   public class ConcurrentChangesOnSameRecordsTask7
    {
        /// <summary>
        /// Problem solved by only using only one connection or introducing transactions isolation levels
        /// </summary>
        public static void ConcurrentChangesOnSameRecords()
        {
            Console.WriteLine();
            Console.WriteLine("Task 7 Concurrent changes on same records\n");

            var firstConection = new DbEFHomewrokEntities();
            var secondConection = new DbEFHomewrokEntities();

            var customerFromFirstConnection = firstConection.Customers.First();
            var customerFromSecondConnnection = secondConection.Customers.First();

            Console.WriteLine("Inital Name FisrtConnection: {0} - SecondCon {1}", customerFromFirstConnection.CompanyName, customerFromSecondConnnection.CompanyName);

            customerFromFirstConnection.CompanyName = "Mercedes";

            // Second name will win.
            customerFromSecondConnnection.CompanyName = "Jaguar";

            firstConection.SaveChanges();
            secondConection.SaveChanges();

            var result = new DbEFHomewrokEntities().Customers.First();
            Console.WriteLine("Name After Change: {0}", result.CompanyName);

            Console.WriteLine(new string('-', 50));

        }
    }
}
