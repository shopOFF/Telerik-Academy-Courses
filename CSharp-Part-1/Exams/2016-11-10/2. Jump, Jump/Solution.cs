using System;

class JumpJump
{
    static void Main()
    {
        var instructions = Console.ReadLine();

        var i = 0;

        while(0 <= i && i < instructions.Length)
        {
            if(instructions[i] == '0')
            {
                Console.WriteLine("Too drunk to go on after {0}!", i);
                return;
            }

            if(instructions[i] == '^')
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                return;
            }

            var code = instructions[i] - '0';
            
            if(code % 2 == 0)
            {
                i += code;
            }
            else
            {
                i -= code;
            }
        }

        if(i < 0 || instructions.Length <= i)
        {
            Console.WriteLine("Fell off the dancefloor at {0}!", i);
        }
    }
}