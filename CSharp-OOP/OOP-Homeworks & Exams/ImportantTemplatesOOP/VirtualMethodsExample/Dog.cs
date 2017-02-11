namespace VirtualMethodsExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Dog : Animal  // ЩОМ НАСЛЕДЯВАМЕ ЖИВОТНОТО СЛЕД, КАТО НАПИШЕ override ВЕЧЕ НИ ИЗЛИЗА И ВИРТУАЛНИЯ МЕТОД Greet ОТ БАЗОВ КЛАС,
    {                           // КОЙТО МОЖЕМ ДА СИ ПРЕЗАПИШЕМ!!!!
        public override string Greet()
        {
            return base.Greet() +" - Bau!";        // ако искаме да преизползваме от вече дефинираният метод "I am an animal" да си изпише  и двете.
        }                                               // МУ КАЗВАМЕ base.Greet() + "Bau!" И СЕГА ВЕЧЕ СИ ИЗПОЛЗВАМЕ И БАЗОВАТА ИМПЛЕМЕНТАЦИЯ И ТАЗИ ОТ КЛАСА КУЧЕ
                //МНОГО ВАЗНО!!!!!! // ПРЕИЗПОЛЗВАМЕ СИ КОДА И ГО ПРЕИЗПОЛЗВАМЕ МНОГО ДОБРЕ!!!ТАКА СЕ ПРАВИ! НА ИЗПИТА ПОСЛЕДНОТО, КОЕТО ТРЯБВА ДА НАПРВИМ Е ДА
               // override-НЕМ ToString() ЕТО ТАКА СЕ ПРАВИ, АКО НИ ТРЯБВА И ТОВА ОТ ПЪРВОНАЧАЛНИЯ МЕТОД, КАТО ИЗВИКАМЕ БАЗОВИЯ(МЕТОД ИЛИ ТОВА, КОЕТО ЩЕ ОУВЪРРАЙДНЕМ) + НОВОТО НЕЩО КОЕТО ИСКАМЕ!!! 

       public void Run()
        {
            Console.WriteLine("I am running");
        }
   }  
}
