using System;
using System.Linq;

namespace TelerikDBEntityFrameworkHW
{
    public class NorthwindEntitiesDemoTask1
    {
        public void Task1Method()
        {
            Console.WriteLine("Task 1 create a DbContext for the Northwind database: \nThe names of all customers in London\n");

            using (var db = new DbEFHomewrokEntities())
            {
                var customerName = db.Customers
                     .Where(c => c.City == "London")
                     .Select(c => c.ContactName)
                     .ToList();

                Console.WriteLine(string.Join("\n", customerName));
            }

            Console.WriteLine(new string('-', 50));

            // ТЕСТ НА ЛИНК!!!! 
            //var customerName = db.Customers
            //        .OrderBy(c => c.ContactName)
            //        .ThenBy(c => c.Country)
            //        .Where(c => c.City == "London")
            //        .Select(c => c.ContactName);
            ////.Where(c => c.City == "London")
            ///*.Select(c => c.ContactName)*/

            //Console.WriteLine(string.Join("\n", customerName));
        }
    }
}
