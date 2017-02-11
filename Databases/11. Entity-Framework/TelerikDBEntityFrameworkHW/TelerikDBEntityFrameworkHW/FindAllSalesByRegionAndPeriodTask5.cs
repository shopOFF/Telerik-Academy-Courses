using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikDBEntityFrameworkHW
{
    public class FindAllSalesByRegionAndPeriodTask5
    {
        public static void FindAllSalesByRegionAndPeriod()
        {
            Console.WriteLine();
            Console.WriteLine("Task 5 Find All Sales By Region And Period\n");

            using (var db = new DbEFHomewrokEntities())
            {
                var sales = db.Orders
                      .Where(o => o.ShipRegion == "Essex")
                      .Where(o => o.ShippedDate.Value.Year == 1997 || o.ShippedDate.Value.Year == 1998)
                      .OrderBy(o => o.ShippedDate)
                      .ToList();

                foreach (var item in sales)
                {
                    Console.WriteLine("Order has ID: {0}, Ship Region: {1}, Shipped Date: {2}", item.OrderID, item.ShipRegion, item.ShippedDate);
                }

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
