namespace _02.DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class StartUpExampless
    {
       public static void Main()
        {
            #region Structures
            // Structure Exampless
            var point = new Point(); // нов обект от Point
            point.X = 4.5m;      // даваме стойност на точка X
            point.Y = 18.9m;     // даваме стойност на точка Y

            Console.WriteLine(point.GetCoordinates());  // и си викаме метода 
            #endregion

            #region Generic
            // Generic Exampless

            var myList = new Generic<int>();  // ето така се използва, като всеки друг клас, но му добавяме <int> след името и в класа вече можем да си пишем Т-та(темплейти), а от тук задаваме в шаблона 
                                              // с какъв точно тип данни искаме да работим, в случая int, но може да е всичко , string, Cat... итн...
            myList.Add(1);         // така се добавя в него и тн. като при всяка др колекция
            myList.Add(2);
                             
            #endregion
        }
    }


}
