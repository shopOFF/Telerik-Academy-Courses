namespace _03.ExtMethodsLambdaExprLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //ТОВА Е ОСТАРЯЛ НАЧИН ЗА ПИСАНЕ НА ДЕЛЕГАТИ !!!!!!!!!!!
   // public delegate void SimpleDelegate(string param); // ето така ... искам един делегат който да ми пази стринг, могат да връщат и инт, лонг и тн(вместо void пишем int) или пък да приема различни параметри(int, string , long) или няколко от тях итн...
    public class Delegates
    {
        // Делегата пази референция към метод, той е променлива, в която можете да пазите метод.Във всеки 1 момент можете да извикате делегата
        // и делегата ще извика методите, които са запазени в него. Основният + е че в 1 делегат можете да добавяте и вадите методи и тн...
        // Делегата е тип, който пази метод, като референция. Идеята му е, че всеки един делегат,
        // описва каква е сигнатурата на дедаения метод. Тоест, ако имате делегат, който приема интове
        // този делегат може да пази в себе си всички методи, който имат един параметър и този параметър е инт.
        // Като, за да съвпада сигнатурата, броя параметри, типа параметри да бъдат подредени по един начин и да 
        // има return type-а, това всъщност показва един етод, като уникален и това нещо фактически можете да пазите
        // в делегат. ТОЕСТ СТОЙНОСТТА НА ЕДИН ДЕЛЕГАТ ВСЪЩНОСТ Е МЕТОД!
        // Делегатите са стандартен обект(референтен тип).Повечето LINQ неща работят с делегати.
        // ПРЕДСТАВЕТЕ СИ, ЧЕ НЯКЪДЕ В ПАМЕТТА ВИ СЕ ПАЗИ НАКАКЪВ МЕТОД, И ОБИКНОВЕННО МОЖЕТЕ ДА КАЖЕТЕ ИМЕТО НА МЕТОДА
        // ДВЕ СКОБИ И ДА ГО ИЗВИКАТЕ, ОБАЧЕ ВЕЧЕ МОЖЕТЕ ДА КАЖЕТЕ И ДРУГО- ИСКАМ ЕТО ТАЗИ ПРОМЕНЛИВА ДА ПАЗИ ТОЗИ МЕТОД-
        // ТОВА Е ВСЪЩНОСТ ДЕЛЕГАТА !!! И ДЕЛЕГАТА СЕ ДЪРЖИ КАТО ПРОМЕНЛИВА И МОЖЕ ДА СИ Я ПОДАВАМЕ НАЛЯВО НАДЯСНО!!!(Като функциите е в JS или C++)
        // В ЕДИН ДЕЛЕГАТ МОЖЕТЕ ДА ЗАПАЗИТЕ ПОВЕЧЕ ОТ ЕДИН МЕТОД, МОЖЕ ДА ЗАПАЗИТЕ МНОГО МЕТОДИ(multicast delegates)!
        // Идеята, е че може да запазите 15 метода на 1 място и след това, с едно извикване на този делегат да извикате и 15-те метода
        // един след друг.

        // Делегата не е част от клас и се дефинира в даден неймспейс като клас, може дасе дефинира и в клас, ако искаме. Дефинира се по този начин:
        // public delegate void SinpleDelegate(string param); // няма боди няма нищо това е
        
        // пример:

        //private static void TestMethod(string param)
        //{
        //    Console.WriteLine("I was called by a delegate.");
        //    Console.WriteLine("I got parameter: {0}.", param);
        //}

        //private static void Main()
        //{
        //    // Instantiate the delegate
        //    SimpleDelegate d = new SimpleDelegate(TestMethod);

        //    // The above can be written in a shorter way
        //    d = TestMethod;

        //    // Invocation of the method, pointed by delegate
        //    d("test");
        //}
    }
}
// Мулти каст делегати: пример:
//using System;

//public delegate int StringDelegate<T>(T value);

//public class Program
//{
//    public static void Main()
//    {
//        StringDelegate<string> d = Program.PrintString;
//        Program instance = new Program();
//        d += instance.PrintStringLength;
//        d += delegate (string str)
//        {
//            Console.WriteLine("Uppercase: {0}", str.ToUpper());
//            return 3;
//        };

//        int result = d("some string value");
//        Console.WriteLine("Returned result: {0}", result);

//        Func<string, int> predefinedIntParse = int.Parse;
//        int number = predefinedIntParse("10");
//        Console.WriteLine(number);

//        Action<object> predefinedAction = Console.WriteLine;
//        predefinedAction(1000);
//    }

//    private static int PrintString(string str)
//    {
//        Console.WriteLine("Str: {0}", str);
//        return 1;
//    }

//    private int PrintStringLength(string value)
//    {
//        Console.WriteLine("Length: {0}", value.Length);
//        return 2;
//    }
//}