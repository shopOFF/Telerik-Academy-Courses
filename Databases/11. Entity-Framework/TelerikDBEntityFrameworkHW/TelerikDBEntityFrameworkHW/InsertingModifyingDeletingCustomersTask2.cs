using System;
using System.Linq;

namespace TelerikDBEntityFrameworkHW
{
    public class InsertingModifyingDeletingCustomersTask2
    {
        public static void InsertCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("Task 2 Inserting Modifying Deleting Customers");

            using (var db = new DbEFHomewrokEntities())
            {
                var customer = new Customer
                {
                    CustomerID = "TEST",
                    CompanyName = "Test Company",
                    ContactName = "Haralampi Lampev",
                    ContactTitle = "Owner",
                    Address = "Trepetlika 13",
                    City = "Spanchovo",
                    Region = "Iugozapaden",
                    Country = "Bulgaria",
                    Phone = "0899999999"
                };

                Console.WriteLine("\n");
                Console.WriteLine("Added new customer with ContactName {0} to customers table!", customer.ContactName);

                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void ModifyCustomer()
        {
            using (var db = new DbEFHomewrokEntities())
            {
                var customerToModify = db.Customers
                      .Where(c => c.CustomerID == "TEST")
                      .FirstOrDefault();

                customerToModify.Country = "USA";
                customerToModify.City = "Annapolis";
                customerToModify.Region = "MD";
                customerToModify.PostalCode = "131313";
                customerToModify.Address = "Melrob Court 13";

                Console.WriteLine("\n");
                Console.WriteLine("Modified customer with ContactName {0}, changed his Country, City, Region, PostalCode and Address in customers table!", customerToModify.ContactName);

                // няма Add или Remove и тн !!! това е мн важно!!! директно си записваме промените!!! 
                db.SaveChanges();
            }
        }

        public static void DeleteCustomer()
        {
            using (var db = new DbEFHomewrokEntities())
            {
                var customerToDelete = db.Customers
                      .Where(c => c.CustomerID == "TEST")
                      .ToList();

                Console.WriteLine("\n");
                Console.WriteLine("Deleted customer with ContactName {0} from customers table!", customerToDelete.FirstOrDefault().ContactName);
                Console.WriteLine(new string('-', 50));

                db.Customers.Remove(customerToDelete.FirstOrDefault());
                db.SaveChanges();
            }

            // втори вариант с firstorDefault директно горе във fluent Api-to
            //using (var db = new DbEFHomewrokEntities())
            //{
            //    var customerToDelete = db.Customers
            //          .Where(c => c.CustomerID == "TEST")
            //          .FirstOrDefault();

            //    Console.WriteLine(new string('-', 50));
            //    Console.WriteLine("Deleted customer with ContactName {0} from customers table!", customerToDelete.ContactName);

            //    db.Customers.Remove(customerToDelete);
            //    db.SaveChanges();
            //}
        }
    }
}
