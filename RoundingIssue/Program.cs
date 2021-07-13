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
			Console.Write("=======================================");
			Console.WriteLine($"Double (1.10): {Math.Round(1.10, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.11): {Math.Round(1.11, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.12): {Math.Round(1.12, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.13): {Math.Round(1.13, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.14): {Math.Round(1.14, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.15): {Math.Round(1.15, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.16): {Math.Round(1.16, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.17): {Math.Round(1.17, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.18): {Math.Round(1.18, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Double (1.19): {Math.Round(1.19, 1, MidpointRounding.AwayFromZero)}");
			Console.Write("=======================================");
			Console.WriteLine($"Decimal (1.10): {Math.Round((decimal)1.10, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.11): {Math.Round((decimal)1.11, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.12): {Math.Round((decimal)1.12, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.13): {Math.Round((decimal)1.13, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.14): {Math.Round((decimal)1.14, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.15): {Math.Round((decimal)1.15, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.16): {Math.Round((decimal)1.16, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.17): {Math.Round((decimal)1.17, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.18): {Math.Round((decimal)1.18, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Decimal (1.19): {Math.Round((decimal)1.19, 1, MidpointRounding.AwayFromZero)}");
			Console.Write("=======================================");
			Console.WriteLine($"Float (1.10): {Math.Round(1.10f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.11): {Math.Round(1.11f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.12): {Math.Round(1.12f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.13): {Math.Round(1.13f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.14): {Math.Round(1.14f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.15): {Math.Round(1.15f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.16): {Math.Round(1.16f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.17): {Math.Round(1.17f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.18): {Math.Round(1.18f, 1, MidpointRounding.AwayFromZero)}");
			Console.WriteLine($"Float (1.19): {Math.Round(1.19f, 1, MidpointRounding.AwayFromZero)}");
		}
	}
}
