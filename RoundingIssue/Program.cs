using System;

namespace RoundingIssue
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine($"Double (1.05): {Math.Round(1.05, 1, MidpointRounding.AwayFromZero)} - Float (1.05f): {Math.Round(1.05f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.05): {Math.Round((decimal)1.05, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.15): {Math.Round(1.15, 1, MidpointRounding.AwayFromZero)} - Float (1.15f): {Math.Round(1.15f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.15): {Math.Round((decimal)1.15, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.25): {Math.Round(1.25, 1, MidpointRounding.AwayFromZero)} - Float (1.25f): {Math.Round(1.25f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.25): {Math.Round((decimal)1.25, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.35): {Math.Round(1.35, 1, MidpointRounding.AwayFromZero)} - Float (1.35f): {Math.Round(1.35f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.35): {Math.Round((decimal)1.35, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.45): {Math.Round(1.45, 1, MidpointRounding.AwayFromZero)} - Float (1.45f): {Math.Round(1.45f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.45): {Math.Round((decimal)1.45, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.55): {Math.Round(1.55, 1, MidpointRounding.AwayFromZero)} - Float (1.55f): {Math.Round(1.55f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.55): {Math.Round((decimal)1.55, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.65): {Math.Round(1.65, 1, MidpointRounding.AwayFromZero)} - Float (1.65f): {Math.Round(1.65f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.65): {Math.Round((decimal)1.65, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.75): {Math.Round(1.75, 1, MidpointRounding.AwayFromZero)} - Float (1.75f): {Math.Round(1.75f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.75): {Math.Round((decimal)1.75, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.85): {Math.Round(1.85, 1, MidpointRounding.AwayFromZero)} - Float (1.85f): {Math.Round(1.85f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.85): {Math.Round((decimal)1.85, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.95): {Math.Round(1.95, 1, MidpointRounding.AwayFromZero)} - Float (1.95f): {Math.Round(1.95f, 1, MidpointRounding.AwayFromZero)} - Decimal (1.95): {Math.Round((decimal)1.95, 1, MidpointRounding.AwayFromZero)}");
		}
	}
}
