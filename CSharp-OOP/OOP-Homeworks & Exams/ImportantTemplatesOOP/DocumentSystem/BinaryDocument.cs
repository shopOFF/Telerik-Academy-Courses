namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BinaryDocument : Document, IDocument // имплементираме си пак базовия клас и интерфейса 
    {
        public BinaryDocument(string name, long size)  // отново ни трябва 1 констр само за задължителните стпйности
            :base(name)
        {
            this.Size = size;
        }
        public BinaryDocument(string name, string content, long size)     // отново взимаме content от базовия клас и констр, който е опционална стойност, затова е в отделен клас
            : base(name, content)                                           
        {
            this.Size = size;
        }

        public long Size { get; private set; }    // BinaryDocument има Size
    }
}
