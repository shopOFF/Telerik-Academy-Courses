namespace CountWithSplit
{
    using System;

    class Startup
    {
        static void Main()
        {
            // count occurrences of a string within another string via split
            // NOTE: doesnt work for strings like "aa"
            var text = "baconaaaaaaa stuff bacon stuff stuff baconbacon";
            var splitText = text.Split(new[] { "aa" }, StringSplitOptions.None);
            Console.WriteLine(splitText.Length - 1);
        }
    }
}
