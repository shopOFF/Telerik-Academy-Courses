using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

// dava 70 to4ki re6enieto
class GreedyDwarf
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int numberOfPatterns = int.Parse(Console.ReadLine());
        SortedSet<int> maximalCoinsSum = new SortedSet<int>();
        for (int i = 0; i < numberOfPatterns; i++)
        {
            int[] patterns = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<bool> positionVisited = new List<bool>();
            for (int j = 0; j < nums.Length; j++)
            {
                positionVisited.Add(false);
            }
            int position = 0;
            int coinsSum = 0;
            coinsSum += nums[0];
            positionVisited[position] = true;
            position += patterns[0];
            int patternIndex = 1;
            while (true)
            {
                if (position <= nums.Length - 1 && position >= 0)
                {
                    if (positionVisited[position] != false)
                    {
                        break;
                    }

                    coinsSum += nums[position];
                    positionVisited[position] = true;
                    position += patterns[patternIndex];
                    patternIndex++;
                    if (patternIndex >= patterns.Length)
                    {
                        patternIndex = 0;
                    }
                }
                else
                {
                    break;
                }
            }
            maximalCoinsSum.Add(coinsSum);
        }
        Console.WriteLine(maximalCoinsSum.Max);
    }
}
// vtoro re6enie za 100 to4ki
//using System;
 
//class Dwarf
//{
//    static void Main()
//    {
//        string[] valleyNumbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
//        int[] Numbers = new int[valleyNumbers.Length];
 
//        for (int i = 0; i < Numbers.Length; i++)
//        {
//            Numbers[i] = int.Parse(valleyNumbers[i]);
//        }
 
//        int Patterns = int.Parse(Console.ReadLine());
//        long BestSum = long.MinValue;
 
//        for (int i = 0; i < Patterns; i++)
//        {
//            long sum = Procces(Numbers);
 
//            if (sum > BestSum)
//            {
//                BestSum = sum;
//            }
//        }
//        Console.WriteLine(BestSum);
//    }
 
 
//    private static long Procces(int[] valley)
//    {
//        string[] valleyNumbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
//        int[] pattern = new int[valleyNumbers.Length];
 
//        for (int i = 0; i < pattern.Length; i++)
//        {
//            pattern[i] = int.Parse(valleyNumbers[i]);
//        }
 
//        bool[] visited = new bool[valley.Length];
//        long CoinSum = 0;
//        CoinSum += valley[0];
//        visited[0] = true;
//        int currentPosition = 0;
//        int nextMove = 0;
//        int h = 0;
 
//        while (true)
//            {
//                nextMove = currentPosition + pattern[h];
 
//            if (nextMove >= 0 && nextMove < valley.Length && !visited[nextMove])
//            {
//                CoinSum += valley[nextMove];
//                visited[nextMove] = true;
//                currentPosition = nextMove;
//                h++;
//            }
//            else
//            {
//                return CoinSum;
//            }
 
//            if (h == pattern.Length)
//            {
//                nextMove = 0;
//                h = 0;
//            }
//            }
//    }
//}