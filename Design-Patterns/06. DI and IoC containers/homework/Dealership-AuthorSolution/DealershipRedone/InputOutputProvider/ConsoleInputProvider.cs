using System;

namespace DealershipRedone.InputOutputProvider
{
    public class ConsoleInputProvider : IInputProvider
    {
        public string ReadLineInput()
        {
            return Console.ReadLine();
        }

        public int ReadInput()
        {
            return Console.Read();
        }
    }
}
