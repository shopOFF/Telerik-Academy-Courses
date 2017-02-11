namespace _02.DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OperatorsOverloading
    {
        // Как да събираме,изваждаме(може да оувърлоадваме всички оператори) и тн обекти, класове и др ...

        //public static  Matrix operator*(Matrix m1, Matrix m2) // имаме статичен метод Маtrix(типа данни който връща), оператора който искаме да оувърлоаднем(виведем) и двете стойности, върху които оператора работи
        //{
        //    return new m1.Multiply(m2);  // и си правим каквото и да е като логика 
        //}

        // ПРИМЕР: има и примери от домашното DefiningClasses 2 мн добри

        //public static Cat operator +(Cat first, Cat second)
        //{
        //    return null;   // можем да си връщаме каквито искаме простотии , да имаме валидации , методи и всякакви други
        //}

        //public static void Main()
        //{
        //    var firstCat = new Cat(CatColor.Black);
        //    var secondCat = new Cat(CatColor.Brown);

        //    var result = firstCat + secondCat;  // и си събираме котки  сега резултат ще ни бъде null (защото сме го задали да връща нълл)
        //}

    }
}
