using System;
class DoWhileLoop
{
	public static void Main(string[] args)
	{
		int i = 1, product;
		Console.WriteLine("Enter a number: ");
		int n = int.Parse(Console.ReadLine());
		do
		{
			product = n * i;
			Console.WriteLine("{0} * {1} = {2}", n, i, product);
			i++;
		} while (i <= 10);
	}
}
