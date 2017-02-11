namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Document : IDocument // наследяваме Идокумент(искам да имплементирам тоя интерфейс му казваме), понеже ни е по условие и ни дава желаните свойства и методи, щом го наследим започва да пищи и задължително трябва да имплементираме 3-те неща, който има в него !!!!
    {              // даваме му котрол и точка и може автоматично да ни създаде пропъртитата, който иска интерфейса да се имплементират!
                   // понеже сетърите на контент и нейм са прайвет, те могът да взимат стойност от външния свят само през конструктори!!!!!Иначе щеше да може директно да задаваме стойност на пропъртитата от вън!!!
        public Document(string name)   // по условие имаме задължително име, което значи, че трябва да си направиме конструктор(само за него,отделен), който да търси първоначално име, при създаване на нов обект!!!Ако имаме и др задължителни работи и те може да са тук в този конструктор  
        {                               
            this.Name = name;
        }
        public Document(string name, string content) 
            : this(name)        // ето така ще вземе от горния контруктор името с думичкат this()и името и от този конструктор contenta
        {
            this.Content = content;
        }
        public string Content { get; private set; }   // имаме само гетъри по условие, но ще си направиме private set ей така, за упражнение
        public string Name { get; private set; }

        public virtual string Information()  // може и с public override string ToString() горе доло едно и също правят
        {
            return this.Name + " " + this.Content;
        }
    }
}
