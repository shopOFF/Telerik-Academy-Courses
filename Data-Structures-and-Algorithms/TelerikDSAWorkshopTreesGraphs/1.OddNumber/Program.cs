using System;
using System.Collections.Generic;

namespace _1.OddNumber
{
    public class Program
    {
        public static void Main()
        {
            var inputLength = int.Parse(Console.ReadLine());
            long number;

            var dict = new Dictionary<long, byte>();

            for (int i = 0; i < inputLength; i++)
            {
                number = long.Parse(Console.ReadLine());

                if (dict.ContainsKey(number))
                {
                    dict[number] = ++dict[number];
                }
                else
                {
                    dict[number] = 1;
                }

                if (i % 1000 == 0)
                {
                    GC.Collect();
                }
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}

// ВТОРИ ВАРИАНТ С БУЛЛЕВИ В РЕЧНИКА, СЪШО МНОГО ДОБРО !!!!!
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.OddNumber
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            var inputLength = int.Parse(Console.ReadLine());
//            long number;

//            var dict = new Dictionary<long, bool>();

//            for (int i = 0; i < inputLength; i++)
//            {
//                number = long.Parse(Console.ReadLine());

//                if (dict.ContainsKey(number))
//                {
//                    dict[number] = !dict[number]; // ПРИ ВСЯКО ДОБАВЯНЕ НА ПОВТАРЯЩО СЕ ЧИСЛО, ЩЕ ГО ПРАВИ, НА ТРУ ПРИ ЧЕТНИ ПОВТАРЯНЯ И НА ФОЛС ПРИ НЕЧЕТНИ
//                }
//                else
//                {
//                    dict.Add(number, !true);  //ПРИ ПЪРВО ДОБАВЯНЕ НА ЧИСЛО, ДИРЕКТНО СИ ГО ПРАВИМ НА ФОЛС ЗНАЧИ СЕ ПОВТАРЯ НЕЧЕТЕН БРОЙ ПЪТИ
//                }

//                if (i % 1000 == 0)
//                {
//                    GC.Collect();
//                }
//            }

//            foreach (var item in dict)
//            {
//                if (item.Value == false)
//                {
//                    Console.WriteLine(item.Key);
//                    break;
//                }
//            }
//        }
//    }
//}
