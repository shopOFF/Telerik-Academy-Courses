using System;

namespace DealershipRedone.InputOutputProvider
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void WriteLineOutput(string value)
        {
            Console.WriteLine(value);
        }

        public void WriteOutput(string value)
        {
            Console.Write(value);
        }
    }
}
