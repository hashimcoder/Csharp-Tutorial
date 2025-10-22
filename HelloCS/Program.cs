using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		Console.Clear();
		Console.WriteLine("Welcome to HelloCS — a beginner C# console app!");

		while (true)
		{
			Console.WriteLine();
			Console.WriteLine("Choose an option:");
			Console.WriteLine("1) Greet me");
			Console.WriteLine("2) Add two numbers");
			Console.WriteLine("3) Show multiplication table");
			Console.WriteLine("5) Run LINQ example");
			Console.WriteLine("6) Run async example (downloads)");
			Console.WriteLine("4) Exit");
			Console.Write("Option: ");

			var choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					Greet();
					break;
				case "2":
					AddTwoNumbers();
					break;
				case "3":
					MultiplicationTable();
					break;
				case "5":
					LinqExample.Run();
					break;
				case "6":
					await AsyncExample.Run();
					break;
				case "4":
					Console.WriteLine("Goodbye!");
					return;
				default:
					Console.WriteLine("Invalid option — try 1, 2, 3, or 4.");
					break;
			}
		}
	}

	static void Greet()
	{
		Console.Write("Enter your name: ");
		var name = Console.ReadLine();
		if (string.IsNullOrWhiteSpace(name)) name = "friend";
		Console.WriteLine($"Hello, {name}! Nice to meet you.");
	}

	static void AddTwoNumbers()
	{
		Console.WriteLine("This will add two integers you enter.");
		int a = ReadInt("First number: ");
		int b = ReadInt("Second number: ");
		Console.WriteLine($"{a} + {b} = {a + b}");
	}

	static void MultiplicationTable()
	{
		int n = ReadInt("Show table for which number: ");
		Console.WriteLine($"Multiplication table for {n}:");
		for (int i = 1; i <= 12; i++)
		{
			Console.WriteLine($"{n} x {i} = {n * i}");
		}
	}

	static int ReadInt(string prompt)
	{
		while (true)
		{
			Console.Write(prompt);
			var s = Console.ReadLine();
			if (int.TryParse(s, out var value)) return value;
			Console.WriteLine("That's not a valid integer — please try again.");
		}
	}
}
