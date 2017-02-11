namespace Cat.Solution
{
    using System;
    using System.Linq;

    class Startup
    {
        static int soulsCollected = 0;
        static int foodCollected = 0;
        static int deadlocks = 0;
        static int index = 0;
        static string[] field = null;
        static int jumpsToDeadlock = 0;

        static void Main()
        {
            soulsCollected = 0;
            foodCollected = 0;
            deadlocks = 0;
            index = 0;
            jumpsToDeadlock = 0;

            field = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();
            var command = Console.ReadLine();

            var jumps = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            if (CheckPosition())
                return;

            foreach (var jump in jumps)
            {
                Move(jump);
                jumpsToDeadlock++;
                if (CheckPosition())
                    return;
            }

            Console.WriteLine("Coder souls collected: {0}\r\nFood collected: {1}\r\nDeadlocks: {2}", soulsCollected, foodCollected, deadlocks);
        }

        static void Move(int jump)
        {
            index = (index + jump) % field.Length;

            if (index < 0)
            {
                index += field.Length;
            }
        }

        static bool CheckPosition()
        {
            if (field[index] == "@")
            {
                field[index] = "0";
                soulsCollected += 1;
            }
            else if (field[index] == "*")
            {
                field[index] = "0";
                foodCollected += 1;
            }
            else if (field[index] == "x")
            {
                deadlocks++;

                if (index % 2 == 0)
                {
                    if (soulsCollected < 1)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", jumpsToDeadlock);
                        return true;
                    }

                    field[index] = "@";
                    soulsCollected -= 1;
                }
                else
                {
                    if (foodCollected < 1)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", jumpsToDeadlock);
                        return true;
                    }

                    field[index] = "*";
                    foodCollected -= 1;
                }
            }
            return false;
        }
    }
}
