using System;
using System.Data.Linq;
using System.Linq;

namespace TelerikDBEntityFrameworkHW
{
    public class InheritingEmployeeClassTask8
    {
        public static void InheritingEmployeeClass()
        {
            Console.WriteLine();
            Console.WriteLine("Task 8 Extend Employee class\n");

            using (var northwindEntities = new DbEFHomewrokEntities())
            {
                var employee = northwindEntities.Employees.First();

                EntitySet<Territory> territories = employee.TerritoriesSet;

                Console.WriteLine("All territories for employee {0} are:", employee.FirstName);

                foreach (var territory in territories)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }

            Console.WriteLine(new string('-', 50));

        }
    }
}
