namespace _04.PrinciplesInOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUpExamples
    {
        // 4-те Принципа НА ООП-
        // Inheritance - inherit members from parent class (Наследяването е: имате си един базов клас човек, и имате негови деца, който го наследяват и взимате вс негови пропъртита, методи  и тн..)
        // Abstraction - define and execute abstract action (Идеята е да генеразлизираме по някакъв начин обектите, които пишем,например: имаме кола базов клас(с вс общи особености на 1 кола(4 гуми, двигател и тн),  и след това наследници примерно Ауди(), Мерцедес(), БМВ() и тн, те пък имат свойте собствени модели и тн...)
        // Идеята е мн лесно да добавяме нови класове и функционалност. Това става с правилно структуриране.
        // Encapsulation - hide the internals of a class (скриването на данните)(всички което променя по някакъв начин класа трябва да бъде скрито(енкапсулирано), вече ако ни трябва да се пипа си го правим публик..)(при енкапсулираните пропъртита с private set например(данните могат да се задават(СЕТВАТ) само през конструктор)ТОВА Е ЦЯЛАТА ИДЕЯ НА ЕНКАПСУЛАЦИУЯТА, И САМО ПРЕЗ КОНСТРУКТОРОТВЪН ДА СЕ СЕТВА СТОЙНОСТ НА ДАДЕНО НЕЩО, А ПЪК САМО ЗА ЧЕТЕНЕ И ТН И ПРЕЗ ПРОПЪРТИТАТА СТАВА,АКО НЕ СА ПРАЙВЕТ GET-ЪРИТЕ И ТН )
        // Polymorphism - access a class through it's parent interface (идеята е да използвате, базовите интерфейси,базовите класове, вместо контретните имплементации)
        public static void Main()
        {
            var puppy = new Dog(5, "pitbul");

            puppy.Sleep();
            puppy.WagTail();
            Console.WriteLine("{0} {1}",puppy.Age,puppy.Breed);
        }
    }
}
