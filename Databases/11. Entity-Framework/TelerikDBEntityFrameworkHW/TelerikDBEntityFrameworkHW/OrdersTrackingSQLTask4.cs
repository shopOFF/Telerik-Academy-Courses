using System;

namespace TelerikDBEntityFrameworkHW
{
   public class OrdersTrackingSQLTask4
    {
        public static void FindAllCustomersWithOrdersFrom1997AndShippedToCanadaUsingSQL()
        {
            Console.WriteLine();
            Console.WriteLine("Task 4 Find all customers who have orders made in 1997 and shipped to Canada With native SQL\n");

            using (var db = new DbEFHomewrokEntities())
            {
                string nativeSqlQuery =
                "SELECT * FROM dbo.Orders o " +
                "JOIN dbo.Customers c " +
                "ON o.CustomerID = c.CustomerID " +
                "WHERE (OrderDate BETWEEN '1997.01.01' AND '1997.12.31') AND ShipCountry = 'Canada' " +
                "ORDER BY c.CompanyName";

                var findCustomers = db.Database.SqlQuery<OrdersToCanada>(nativeSqlQuery);

                foreach (var item in findCustomers)
                {
                    Console.WriteLine(item.ContactName);
                }

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
