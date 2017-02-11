namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OfficeDocument : BinaryDocument, IDocument  // всеки път си наследяваме и интерфейса, просто за да е по прегледно и описателно
    {
        public OfficeDocument(string name, string content, long size, string version)  // може и content в отделен конструктор(понеже не е задължителен), но може и тук ....
            : base(name, content, size)
        {
            this.Version = version;
        }
        public string Version { get; private set; }  // желателно е винаги сет-а да  е private(да е енкапсулиран), освен ако изрично не сме сигурни, че трябва да се сетва или го имаме по условие...
    }
}
