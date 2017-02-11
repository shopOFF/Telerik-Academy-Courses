namespace ExampleWithCollections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ExampleWithCollectionsInterfaces
    {
        //ПРИМЕР КАК С ВДИГАНЕ НА АБСТРАКЦИЯТА ЧРЕЗ ИНТЕРФЕЙС (В ПРИМЕРА С IEnumerable, ПОНЕЖЕ НИ ТРЯБВА САМО foreach) МОЖЕМ ДА СИ foreach-ВАМЕ ВСЯКАКВИ КОЛЕКЦИИ СТИГА ТЕ ДА ИМПЛЕМЕНТИРАТ  IEnumerable!!!,
        // МОЖЕМ ДА СИ ВДИГНЕМ АБСТРАКЦИЯТА ОЩЕ ПОВЕЧЕ И ДА ГО  НАПРАВИМ  И Generic , ТАКА ЩЕ МОЖЕМ ОСВЕН И ИНТОВЕ И ВСЯКАКВИ ДРУГИ ТИПОВЕ ДАННИ ДА МУ ПОДАВАМЕ(string, bool)!!!
        public static void Main()
        {
            Console.WriteLine("This is the List:");  // за да е по прегледно
            var list = new List<int> { 4, 5, 67, 21, 12, 13 };   // набиваме му List и метода работи !
            Print(list);

            Console.WriteLine("This is the SortedSet:");
            var sortedNums = new SortedSet<int> { 3, 4, 213213412, 221231, 1212, 12, 13, 7686 };  // набиваме му SortedSet и метода пак работи!
            Print(sortedNums);

            Console.WriteLine("This is the HashSet:");
            var heshNums = new HashSet<int> { 3, 4, 2, 1, 1212, 12, 13, 7686 };  // набиваме му HashSet и метода пак работи!
            Print(heshNums);

            Console.WriteLine("This is the Array:");
            var array = new int[] { 13, 13, 13, 13, 13, 13 };  // набиваме му Array(масив) и метода пак работи!
            Print(array);

        }
        public static void Print(IEnumerable<int> numbers)  // ето така си вдигаме абстракцията чрез интерфейса!
        {
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
