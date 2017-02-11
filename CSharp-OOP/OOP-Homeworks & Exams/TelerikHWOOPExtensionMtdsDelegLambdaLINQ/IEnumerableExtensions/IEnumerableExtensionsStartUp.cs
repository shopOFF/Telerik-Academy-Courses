namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using Extensions;
    public class IEnumerableExtensionsStartUp
    {
        public static void Main()
        {
            var test = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Console.WriteLine("The sum of the collection is: {0}", test.SumOfCollection());
            Console.WriteLine("The product of the collection is: {0}", test.ProductOfCollection());
            Console.WriteLine("The min value in the collection is: {0}", test.MinValueInCollection());
            Console.WriteLine("The max value in the collection is: {0}", test.MaxValueInCollection());
            Console.WriteLine("The average value of the collection is: {0}", test.AverageValueOfCollection());
        }
    }
}
