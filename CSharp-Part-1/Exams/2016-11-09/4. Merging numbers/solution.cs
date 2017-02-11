using System;

class StartUp
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		int[] numbers = new int[n];

		for(int i = 0; i < n; ++i)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}

		int[] merged = new int[n - 1];
		int[] summed = new int[n - 1];

		for(int i = 1; i < n; ++i)
		{
			merged[i - 1] = numbers[i - 1] % 10 * 10 + numbers[i] / 10;
			summed[i - 1] = numbers[i - 1] + numbers[i];
		}

		Console.WriteLine(string.Join(" ", merged));
		Console.WriteLine(string.Join(" ", summed));
	}
}
