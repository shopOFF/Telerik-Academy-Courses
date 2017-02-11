using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSum
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');

        int n = int.Parse(nums[0]);
        int m = int.Parse(nums[1]);
        int currentSum = 0;
        int maxSum = int.MinValue;  // vmesto 0, za6toto po tozi na4in 6te namerim i otricatelnite 4isla (pri polojenie 4e vsi4ki sumi sa ni otricatelni 4isla i trqbva da namerim nai golqmata ot tqh), ako e 0, 6te iz4islqva samo tezi koito sa po golemi ili razvni na 0...! A po uslovie imame i otricatelni 4isla i sledovatelno i samo otricatelni maximalni sborove 
        int[,] matrix = new int[n, m];

        // fill the array
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < input.Length; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        // find the max sum of 3X3 elements  (kletkata po koqto tarsim po uslovie e 3X3)
        for (int i = 0; i < n - 2; i++)   // n-2 za da ne izlezem ot masiva(pri polojenie 4e tarsim 3X3 tri 4isla na vseki ot sledva6tite 3 reda)
        {
            for (int j = 0; j < m - 2; j++)
            {
                for (int k = 0; k < 3; k++)    // vzimame 3 te 4isla ot 3te reda  
                {
                    for (int l = 0; l < 3; l++)  // vzimame si 3 te 4isla ot vseki edin red
                    {
                        currentSum += matrix[i + k, j + l];   // taka si vzimame vseki edin element
                    }
                }
                if (maxSum < currentSum)  // tuk e ulovkata ako maxSum be6e 0 nqma6e da vleze vatre (pri polojenie 4e imame samo otricatelni currentSum), ztova maxSum=trqbva da ni e otricatelno 4islo nai dobre minimalnata mu stoinost int.MinValue
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}
// Друг начин за решаване на същият тип задача също много добър, само че е използвана платформа 2Х2 и има допълнителни изчисления, 
// кой е най-добрия(сборът на числата му е най-голям) ред(от платфорамата) и коя е най-добрата колона!
//using System;

//public class MaxPlatform
//{
//    static void Main()
//    {
//        // Declare and initialize the matrix
//        int[,] matrix =
//            {
//                { 0, 2, 4, 0, 9, 5 },
//                { 7, 1, 3, 3, 2, 1 },
//                { 1, 3, 9, 8, 5, 6 },
//                { 4, 6, 7, 9, 1, 0 }
//            };

//        // Find the maximal sum platform of size 2 x 2
//        int bestSum = int.MinValue;
//        int bestRow = 0;
//        int bestCol = 0;
//        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
//        {
//            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
//            {
//                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

//                if (sum > bestSum)
//                {
//                    bestSum = sum;
//                    bestRow = row;
//                    bestCol = col;
//                }
//            }
//        }

//        // Print the result
//        Console.WriteLine("The best platform is:");
//        Console.WriteLine("  {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
//        Console.WriteLine("  {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
//        Console.WriteLine("The maximal sum is: {0}", bestSum);
//    }
//}