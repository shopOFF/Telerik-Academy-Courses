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

		int[] mixed = new int[n - 1];
		int[] subtracted = new int[n - 1];

		for(int i = 1; i < n; ++i)
		{
			mixed[i - 1] = numbers[i - 1] % 10 * (numbers[i] / 10);
			subtracted[i - 1] = numbers[i - 1] - numbers[i];
			if(subtracted[i - 1] < 0) subtracted[i - 1] *= -1;
		}

		Console.WriteLine(string.Join(" ", mixed));
		Console.WriteLine(string.Join(" ", subtracted));
	}
}
