using System;
class BitWiseOperator
{
    public static void Main(string[] args)
    {
		int result;
		Console.WriteLine("Bitwise Operators");
		Console.WriteLine("\nEnter First Number: "); 
		int a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second Number: ");
		int b = Convert.ToInt32(Console.ReadLine());
		

		result = ~a;
		Console.WriteLine("Bitwise Complement: ~{0} = {1}", a, result);

		result = a & b;
		Console.WriteLine("Bitwise AND: {0} & {1} = {2}", a, b, result);

		result = a | b;
		Console.WriteLine("Bitwise OR: {0} | {1} = {2}", a, b, result);

		result = a ^ b;
		Console.WriteLine("Bitwise Exclusive OR: {0} ^ {1} = {2}", a, b, result);

		result = a << 2;
		Console.WriteLine("Bitwise Left Shift: {0} << 2 = {1}", a, result);

		result = a >> 2;
		Console.WriteLine("Bitwise Right Shift: {0} >> 2 = {1}", a, result);
	}
}