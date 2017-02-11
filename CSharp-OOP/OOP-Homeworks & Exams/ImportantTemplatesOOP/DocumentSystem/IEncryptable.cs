namespace DocumentSystem
{
    public interface IEncryptable
    {
        bool IsEncrypted { get; }  // това са стойнностите по условие, които има интерфейса и трябва да имплементираме в наследниците
        void Encrypt();
        void Decrypt();

    }
}
