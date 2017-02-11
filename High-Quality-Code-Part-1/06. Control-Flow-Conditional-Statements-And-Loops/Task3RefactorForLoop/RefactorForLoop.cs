namespace Task3RefactorForLoop
{
    using System;

    public class RefactorForLoop
    {
        public static void Main()
        {
            var expectedValue = 13;
            var arrayOfNumbers = new int[] { 5, 6, 7, 13, 200, 666, 1313 };

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == expectedValue)
                {
                    Console.WriteLine("Value Found! - {0}", arrayOfNumbers[i]);
                }
                else
                {
                    Console.WriteLine(arrayOfNumbers[i]);
                }
            }
        }
    }
}
