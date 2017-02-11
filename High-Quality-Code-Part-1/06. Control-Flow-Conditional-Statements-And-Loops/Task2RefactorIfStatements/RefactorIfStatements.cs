namespace Task2RefactorIfStatements
{
    using System;

    public class RefactorIfStatements
    {
        public static void Main()
        {
            var potato = new Potato();

            if (potato != null)
            {
                if (potato.IsNotRotten)
                {
                    if (potato.HasBeenPeeled)
                    {
                        Cook(potato);
                    }
                    else
                    {
                        Console.WriteLine("Potato is must be peeled before cooking.");
                    }
                }
                else
                {
                    Console.WriteLine("Potato is rotten.");
                }
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
