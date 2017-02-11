using System;

namespace Variations
{
    public static class RandomGenerator
    {
        private static Random rand = new Random();
        private static string letters = "qwertyuiopasdfghjklzxcvnm";

        public static string GetRandomString(int min, int max)
        {
            int lenght = rand.Next(min, max + 1);
            var result = new char[lenght];

            for (int i = 0; i < lenght; i++)
            {
                result[i] = letters[rand.Next(0, letters.Length)];
            }

            return string.Join("", result);
        }
    }
}