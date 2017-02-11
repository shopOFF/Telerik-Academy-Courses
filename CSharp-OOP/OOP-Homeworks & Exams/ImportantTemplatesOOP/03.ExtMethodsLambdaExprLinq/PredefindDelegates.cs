namespace _03.ExtMethodsLambdaExprLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PredefindDelegates
    {
        // Отново делегати, но по културни, те са енкапсулирани в два класа: Action and Func
        // Action- може да пази всякакви делегати, които не връщат стойности(които са void), всякакви
        // методи който са войд и типовете на Дженерика са типовете, които приема:
        // Това е по модерният, по-добрият начин за правене на делегати с Action и Func.


        // пример Action: <в скобите описваме параметрите, който искаме вътре> и = и самият метод, който искаме да запазим вътре
        //static void Main()
        //{
        //    Action<string, int> myMethod = SomeMethod;
        //    
        //    myMethod("", 0);  // и му подаваме стринга и инта.
        //}
        //public static void SomeMethod(string text, int number)
        //{
        //    Console.WriteLine("Delegate call - ", text + number);
        //}

        // Func пример:
        // ПРИЕМА 2 ПАРАМЕТЪРА: 1-параметър-стринг, 2-ри параметър- лонг И НИ ВРЪЩА ТРЕТОТО ТОЕСТ ИНТ      
        //Func<string, long, int> func = ReturnAnswerToEverything;

        //public static int ReturnAnswerToEverything(string input, long number) 
        //{
        //    return 42;
        //}
    }
}
