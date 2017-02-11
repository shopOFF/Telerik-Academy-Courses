namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person : IPerson  // наследяваме си интерфейса
    {
        public string  Name { get; set; }
                                                    // IEnumerable си слагаме интерфейс за да си вдигнем абстракцията, вече може листове, масиви , хешсетове да ползваме и тн...
        public abstract IEnumerable<string> Courses { get; }  // абстрактен,ще се имплементира в друг клас, защото искаме да си направим за различните нива на студентите да има различни курсовве.Наследниците му да се оправят да ги имплементират

        public string GetAllCourses() // метод който ще ни изписва имената на курсовете
        {
            return string.Join(" ", this.Courses);  // ще ни изписва курсовете,извикваме си тази колекция тук,обаче приемаме, че той някъде ще се имплементира(нали е абстрактен, трябва дасе имполементира от наследниците)
        }
    }
}
