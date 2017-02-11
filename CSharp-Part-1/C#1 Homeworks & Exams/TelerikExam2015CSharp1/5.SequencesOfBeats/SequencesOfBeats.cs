using System;
using System.Linq;
// ne dava vsi4ki to4ki, zada4a BitsToBits e sa6tata i dava vsi4ki to4ki po razli4en na4in e re6ena
class SequencesOfBeats
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] sequenceOfOnes = new int[1000];
        int[] sequenceOfZeroes = new int[1000];

        int onesCounter = 0;
        int zeroesCounter = 0;

        int onesArrayCounter = 0;
        int zeroesArrayCounter = 0;

        for (int i = 0; i < length; i++)
        {
            int nums = int.Parse(Console.ReadLine());

            string numToBin = Convert.ToString(nums, 2).PadLeft(30, '0');

            foreach (var item in numToBin)
            {
                if (item == '1')
                {
                    if (zeroesCounter>0)
                    {
                        sequenceOfZeroes[zeroesArrayCounter]+=zeroesCounter;
                        zeroesArrayCounter++;
                        zeroesCounter = 0;
                    }
                    onesCounter++;
                }
                else
                {
                    if (onesCounter>0)
                    {
                        sequenceOfOnes[onesArrayCounter] += onesCounter;
                        onesArrayCounter++;
                        onesCounter = 0;
                    }
                    
                    zeroesCounter++;
                }
            }
        }
        int maxOnes = sequenceOfOnes.Max();
        int maxZeroes = sequenceOfZeroes.Max();

        Console.WriteLine(maxOnes);
        Console.WriteLine(maxZeroes);
    }
}

