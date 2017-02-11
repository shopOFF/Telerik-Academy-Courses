namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JuniorStudent : Person
    {
        public override IEnumerable<string> Courses   // и така JuniorStudent-а си казва какви са му курсовете!!! правим си го IEnumerable разбира се вдигнали сме абстракцията в Пърсън класа
        {
            get
            {                                          
                return new List<string> { "Fundamentals of C#" };  // ей така в къдравите скоби можем да си пълним листа  { "Fundamentals of C#" }!!!!
            }                   // връщаме си нов лист, но вече може листове, масиви , хешсетове да ползваме и тн... понеже ползваме общия интерфейс IEnumerable
        }
    }
}
