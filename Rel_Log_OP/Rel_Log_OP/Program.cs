using System;

class RelLogOperator
{
    public static void Main(string[] args)
    {
		bool result;
		Console.WriteLine("Relational & Logical Operators");
		Console.WriteLine("\nEnter First Number: ");
		int fN = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second Number: ");
		int sN = Convert.ToInt32(Console.ReadLine());

		result = (fN == sN);
		Console.WriteLine("{0} == {1} returns {2}", fN, sN, result);

		result = (fN > sN);
		Console.WriteLine("{0} > {1} returns {2}", fN, sN, result);

		result = (fN < sN);
		Console.WriteLine("{0} < {1} returns {2}", fN, sN, result);

		result = (fN >= sN);
		Console.WriteLine("{0} >= {1} returns {2}", fN, sN, result);

		result = (fN <= sN);
		Console.WriteLine("{0} <= {1} returns {2}", fN, sN, result);

		result = (fN != sN);
		Console.WriteLine("{0} != {1} returns {2}", fN, sN, result);

		// OR operator
		result = (fN == sN) || (fN > 5);
		Console.WriteLine(result);

		// AND operator
		result = (fN == sN) && (fN > 5);
		Console.WriteLine(result);
	}
}