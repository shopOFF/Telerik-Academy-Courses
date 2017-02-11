using System;

namespace TelerikDBEntityFrameworkHW
{
    public class Start
    {
        public static void Main()
        {
            // 01. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
            var task1 = new NorthwindEntitiesDemoTask1();
            task1.Task1Method();

            // 02. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
            // Write a testing class.

            InsertingModifyingDeletingCustomersTask2.InsertCustomer();
            InsertingModifyingDeletingCustomersTask2.ModifyCustomer();
            InsertingModifyingDeletingCustomersTask2.DeleteCustomer();

            // 03. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

            OrdersTrackingTask3.FindAllCustomersWithOrdersMadeIn1997AndShippedToCanada();

            // 04. Implement previous by using native SQL query and executing it through the DbContext.

            OrdersTrackingSQLTask4.FindAllCustomersWithOrdersFrom1997AndShippedToCanadaUsingSQL();

            // 05. Write a method that finds all the sales by specified region and period (start / end dates).

            FindAllSalesByRegionAndPeriodTask5.FindAllSalesByRegionAndPeriod();

            // 06. Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext.
            // Find for the API for schema generation in MSDN or in Google.

            using (var northwindEntities = new DbEFHomewrokEntities())
            {
                // To solve this task you need to change in the app.config file the connection string to:
                // initial catalog=NorthwindTwin

                Console.WriteLine();
                Console.WriteLine("Task 6 Create DB Clone\n");

                var result = northwindEntities.Database.CreateIfNotExists();

                Console.WriteLine("Database NorthWindTwin is created: {0}", result ? "YES!" : "NO!");
                Console.WriteLine(new string('-', 50));

            }

            // 07. Try to open two different data contexts and perform concurrent changes on the same records.
            // What will happen at SaveChanges() ?
            // How to deal with it ?

            ConcurrentChangesOnSameRecordsTask7.ConcurrentChangesOnSameRecords();

            // 08. By inheriting the Employee entity class create a class which allows employees to access their\
            // corresponding territories as property of type EntitySet<T>.

            InheritingEmployeeClassTask8.InheritingEmployeeClass();
        }
    }
}
