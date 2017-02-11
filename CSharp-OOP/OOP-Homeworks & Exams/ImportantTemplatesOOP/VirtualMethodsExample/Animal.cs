namespace VirtualMethodsExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Animal
    {
        public string Name { get; set; }   // животното си има име

        public virtual string Greet()  //ПРАВИМ СИ ВИРТУАЛЕН МЕТОД ГРИИТ, КОЙТО ЩЕ МОЖЕМ ДА ПРЕЗАПИШЕМ(override-НЕМ) В НАСЛЕДНИЦИТЕ НА Animal. AKO ИСКАМЕ МОЖЕ И ДА НЕ ГО ПРЕЗАПИСВАМЕ!!!ИМАМЕ СВОБОДА!
        {
            return "I am an animal";
        }

        public override string ToString()   // оувъррайдаваме ToString понеже от майкрософт са ни позволили да го направим(имаме си го по дефоут като избор)
        {                                              // презаписването на виртуален метод е почти същото
            return this.GetType().Name + " " + this.Name;    // с this.GetType() си взимаме името на класа и след това му добавяме и името на самото животно! Тука може всчкакви глупости да му презапишем...!!
        }
    }
}
