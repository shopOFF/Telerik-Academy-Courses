namespace GenericClass
{
    using Models;
    using System;
    public class Test
    {
        static void Main()
        {
            var list = new GenericList<int>(5);
            list.Add(5);
            list.Add(10);
            list.Add(20);

            list.Insert(1, 123);

            list.Add(56);

            Console.WriteLine("The elements in the list are: {0}", list);

            Console.WriteLine("The minimal element in the list is: {0}", list.Min());
            Console.WriteLine("The maximal element in the list is: {0}", list.Max());

        }
    }
}
