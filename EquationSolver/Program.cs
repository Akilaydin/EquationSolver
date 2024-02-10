internal class BisectionMethod
{
	private delegate double Function(double x);

	private static void Main(string[] args)
	{
		SolveEquation(Equation1);
		SolveEquation(Equation2);
		SolveEquation(Equation3);
		SolveEquation(Equation4);
	}

	// Equation 1: 2/x + 1 - cos(x) = 0
	private static double Equation1(double x)
	{
		return 2 / x + 1 - Math.Cos(x);
	}

	// Equation 2: x - 2sin(x) = 0
	private static double Equation2(double x)
	{
		return x - 2 * Math.Sin(x);
	}

	// Equation 3: sqrt(x) - 2x - 3 = 0
	private static double Equation3(double x)
	{
		return Math.Sqrt(x) - 2 * x - 3;
	}

	// Equation 4: 5x + 3sqrt(x) + 6 = 0
	private static double Equation4(double x)
	{
		return 5 * x + 3 * Math.Sqrt(x) + 6;
	}

	private static void SolveEquation(Function func, double tolerance = 0.00001)
	{
		Console.WriteLine($"Enter a");
		var a = double.Parse(Console.ReadLine());
		
		Console.WriteLine($"Enter b5");
		var b = double.Parse(Console.ReadLine());
		
		if (func(a) * func(b) >= 0)
		{
			Console.WriteLine("Invalid interval. The function must have different signs at a and b.");
			return;
		}

		var c = a;

		while ((b - a) / 2 > tolerance)
		{
			c = (a + b) / 2;

			if (func(c) == 0.0)
			{
				break;
			}

			if (func(c) * func(a) < 0)
			{
				b = c;
			}
			else
			{
				a = c;
			}
		}

		Console.WriteLine($"A root of the equation is approximately: {c}");
	}
}
