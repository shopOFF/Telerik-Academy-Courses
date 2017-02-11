namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WordDocument : OfficeDocument, IDocument, IEncryptable
    {
        public WordDocument(string name, string content, long size, string version, int numberOfCharacters)
            : base(name, content, size, version)
        {
            this.NumberOfCharacters = numberOfCharacters;
        }

        public int NumberOfCharacters { get; private set; }

        public bool IsEncrypted { get; private set; }   // това са от IEncryptable стойностите вече имплементирани
                                        
        public void Decrypt()                           // методите просто променят от фолс на тру и обратното, доста лесно
        {
            this.IsEncrypted = true;
        }

        public void Encrypt()
        {
            this.IsEncrypted = false;
        }
    }
}
