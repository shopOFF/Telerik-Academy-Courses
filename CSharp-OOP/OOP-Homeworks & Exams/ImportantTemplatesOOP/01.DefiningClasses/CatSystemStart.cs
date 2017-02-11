namespace CatSystem
{
    using System;
    class CatSystemStart   // от тук(този клас, където е main метода)започва програмта
    {
        // правим си прогарамка за котки, Котката си има собственик, който правим в отделен клас
         public static void Main()
        {
            var peshoOwner = new Owner("Pesho","Stambinov"); // създаваме си нов обект(нов owner) от тим Owner, тук ни търси два стринг параметъра
                                                          // да му подадем, за да направи обекта, защото си направихме конструктор, който
                                                          // да приема винаги първо и последно име при създаването на нов owner, ако си бяхме направили
                                                          // празен конструктор, или въобще не бяхме правили конструктор и да оставим дефоутният конструктор да се създаде, 
                                                          // нямаше да има нужда, да му подаваме два стринг параметъра, за да си направим новият Owner!!!!

            var goshoOwner = new Owner("Gosho", "Geshev"); // създаваме си още един нов Owner и сега имаме две инстанции от тип Owner(два обекта от този тип)

            peshoOwner.IncreaseAge();  // това ни вика метода за увеличаване на годините на пешо и увеличава годините на пешо с една
            peshoOwner.IncreaseAge();  // викаме си този метод 5 пъти което ще зададе на Пешо годините да са 5
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();

            Console.WriteLine(peshoOwner.Age);   // принтираме си годините на пешо

            Console.WriteLine(peshoOwner.FullName); // изкарва ни пълното име на peshoOwner

            var cat = new Cat(CatColor.Mixed);  // правим си една котка с исканият от конструктора параметър, цвят на котката
            var anotherCat = new Cat(CatColor.Black);  // правим си още една котка
            var yetAnotherCat = new Cat(CatColor.Brown);   // и още една

            peshoOwner.AddCat(cat, "Maca");   //пешо си взима котка и я кръщава Маца
            peshoOwner.AddCat(anotherCat, "Silvestyr");  // пешо си взима още една котка и я къщава силвестър

            Console.WriteLine(peshoOwner.AllCats);


        }
    }                                                   
}                                                         
