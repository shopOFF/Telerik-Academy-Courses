namespace _05.PrinciplesInOOP2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Polymorphism
    {
        // ПОЛИМОРФИЗМА - НА КРАТКО ПРЕДСТАВЛЯВА ДА ИЗПОЛЗВАТЕ, НЯКАКЪВ КЛАС С НЕГОВИЯ БАЗОВ КЛАС, КОЙТО Е ПО НАГОРЕ.// ПОЛИМОРФИЗМЪТ Е МНОГО ПОЛЕЗЕН!!!!!
        //        Polymorphism = ability to take more than one form(objects have more than one type) - ПРИЕМА ЕДНА ФОРМА, ПОСЛЕ ВТОРА ФОРМА, ТРЕТА ФОРМА И ТН...(НАЙ-ЧЕСТО СЕ ИЗПОЛЗВА С АБСТРАКТНИ МЕТОДИ ИЛИ ВИРТУАЛНИ МЕТОДИ!)
        //A class can be used through its parent interface
        //A child class may override some of the behaviors of the parent class
        //Polymorphism allows abstract operations to be defined and invoked    // ПОЛИМОРФИЗМЪТ Е МНОГО 
        //Abstract operations are defined in the base class' interface and implemented in the child classes
        //Declared as abstract or virtual

        //        Why handle an object of given type as object of its base type?
        //To invoke abstract operations
        //To mix different related types in the same collection
        //E.g.List<object> can hold anything
        //To pass more specific object to a method that expects a parameter of a more generic type
        //To declare a more generic field which will be initialized and "specialized" later

        // ЩЕ ДЕФИНИРАМЕ ЕДИН КЛАС БАЗОВ ANIMAL , КОЙТО ЩЕ ИМА МЕТОД SPEAK, И ВСИЧКИТЕ ЖИВОТНИ, КОИТО ГО НАСЛЕДЯВАТ ЩЕ СИ ИМПЛЕМЕНТИРАТ ВЕЧЕ КОНКРЕТНО,
        // ВСЯКО ЖИВОТНО КАКВО КАЗВА, КУЧЕТО КАЗВА БАУ, КОТКАТА МЯУ И ТН. СЛЕД ТОВА ЩЕ НАПРАВИМ ЕДИН ЛИСТ ОТ ЖИВОТНИ,( А НЕ ЛИСТ ОТ ТОЧНО ОПРЕДЕЛЕНО ЖИВОТНО),
        // ЩЕ ДОБАВИМ ВЪТРЕ ВСЯКАКВИ ЖИВОТНИ(КУЧЕТА,КОТНКИ ИТН) И НАКРАЯ ЩЕ FOREACH-НЕМ ЦЕЛИЯТ ЛИСТ ОТ ЖИВОТНИ И ЩЕ ИМ КАЖЕМ ВСЕКИ ОТ ТЯХ ДА ГОВОРИ. И ЩЕ ВИДИМ КАК
        // НА КОНЗОЛАТА ВСЕКИ ЕДИН ОТ ТЯХ ЩЕ Е ИЗВИКЪЛ СОБСТВЕНИЯТ СИ МЕТОД(КОТКАТА ЩЕ КАЖЕ МЯУ, КУЧЕТО БАУ О ТН), НИЩО ЧЕ НИЕ РЕАЛНО ИЗПОЛЗВАМЕ ЧИСТО И ПРОСТО ЛИСТ 
        // ОТ ЖИВОТНИ, ПОНЕЖЕ В БАЗОВИЯ КЛАС ЖИВОТНО НЕ СМЕ ДЕФИНИРАЛИ, КОЕ КАК ДА ГОВОРИ!!!(ТОВА Е ПОЛИМОРФИЗМА НАЙ-НА КРАТКО- ВИЕ ДА ИЗПОЛЗВАТЕ БАЗОВИЯ КЛАС
        // ОБАЧЕ В СЪЩОТО ВРЕМЕ ДА СТЕ ИМПЛЕМЕНТИРАЛИ ПО-НАДОЛО В ИЕРАРХИЯТА НЯКАКВИ МЕТОДИ, КОЙТО ВСЪЩНОСТ ТЕ СЕ ИЗВИКВАТ!) 
        
        // ОСНОВНАТА БЛАГИНКА, Е ЧЕ МОЖЕ ДА СЛАГАМЕ В КОЛЕКЦИИ РАЗЛИЧНИ ВИДОВЕ ТИПОВЕ ДАННИ, КОИТО ИМАТ ОБЩ БАЗОВ КЛАС(КАКТО ГОРНИЯ ПРИМЕР С ЖИВОТНИТЕ).ПРАВИМ СИ ЛИСТ ОТ ЖИВОТНИ
        // И В НЕГО СИ ДОБАВЯМЕ РАЗЛИЧНИТЕ ЖИВОТНИ!
        
          
    }
}
