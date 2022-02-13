using System;

	class ArithmeticOperator
	{
		public static void Main(string[] args)
		{
			int result;

			Console.WriteLine("Arithmetic Operation: ");
			Console.WriteLine("Enter First Number: ");
			int n1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Second Number: ");
			int n2 = Convert.ToInt32(Console.ReadLine());

			result = n1 + n2;
			Console.WriteLine("Addtition of {0} + {1} = {2}", n1, n2, result);

			result = n1 - n2;
			Console.WriteLine("Subtraction of {0} - {1} = {2}", n1, n2, result);

			result = n1 * n2;
			Console.WriteLine("Multiplication of {0} * {1} = {2}", n1, n2, result);

			result = n1 / n2;
			Console.WriteLine("Division of {0} / {1} = {2}", n1, n2, result);

			result = n1 % n2;
			Console.WriteLine("Modulo of {0} % {1} = {2}", n1, n2, result);

			result = --n1;
			Console.WriteLine("Decrement = " + result);

			result = ++n1;
			Console.WriteLine("Increment = " + result);

		}
	}