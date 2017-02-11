using System;
using System.Linq;

public class DancingMoves
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        int times = int.Parse(input[0]);
        string direction = input[1];
        int step = int.Parse(input[2]);
        double sum = 0;
        int startinPositionIndex = 0;
        double counter = 1;
        int newIndex = 0;
        while (input[0] != "stop")
        {
            if (direction == "right")
            {
                for (int j = 1; j <= times; j++)
                {
                    if (startinPositionIndex + step > nums.Length - 1)
                    {
                        newIndex = (step + startinPositionIndex) % nums.Length;
                        sum += nums[newIndex];
                        startinPositionIndex = newIndex;
                    }
                    else
                    {
                        sum += nums[(startinPositionIndex + step) % nums.Length];
                        startinPositionIndex += step;
                    }
                }
            }
            else
            {
                for (int j = times - 1; j >= 0; j--)
                {
                    if ((startinPositionIndex - step) % nums.Length < 0)
                    {
                        //int pp = nums.Length - ((step - startinPositionIndex) % nums.Length);
                        int pp = nums.Length + (startinPositionIndex - step) % nums.Length;
                        sum += nums[pp];
                        startinPositionIndex = pp;
                    }
                    else
                    {
                        sum += nums[(startinPositionIndex - step) % nums.Length];
                        startinPositionIndex -= step;
                    }
                }
            }

            input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input.Length > 1)
            {
                times = int.Parse(input[0]);
                direction = input[1];
                step = int.Parse(input[2]);
                counter++;
            }
        }
        Console.WriteLine("{0:F1}", sum / counter);
    }
}