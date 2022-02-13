// C# program to create marksheet for students.
using System;

class Marks
{

	static void Main(string[] args)
	{
		int marks1, marks2, marks3, marks4, total, sem;
		long r;
		float per;
		string n, strm;

		Console.WriteLine("Enter Student's Roll Number :");
		r = Convert.ToInt64(Console.ReadLine());

		Console.WriteLine("Enter Student's Name :");
        n = Console.ReadLine();

		Console.WriteLine("Enter Student's Semester: ");
		sem = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Student's Stream: ");
		strm = Console.ReadLine();

		Console.WriteLine("Enter Subject-1 Marks : ");
		marks1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Subject-2 Marks : ");
		marks2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Subject-3 Marks :");
		marks3 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Subject-4 Marks :");
		marks4 = Convert.ToInt32(Console.ReadLine());

		total = marks1 + marks2 + marks3 + marks4;
		per = total / 4.0f;

		Console.WriteLine("\nFinal result of {0}/{1} studying in {2} {3} semester is:", n, r, strm, sem);
		Console.WriteLine("\tTotal Marks : " + total);
		Console.WriteLine("\tPercentage : " + per);

		if (per <= 35)
			Console.WriteLine("\tGrade is F");
		else if (per >= 34 && per <= 39)
			Console.WriteLine("\tGrade is D");
		else if (per >= 40 && per <= 59)
			Console.WriteLine("\tGrade is C");
		else if (per >= 60 && per <= 69)
			Console.WriteLine("\tGrade is B");
		else if (per >= 70 && per <= 79)
			Console.WriteLine("\tGrade is B+");
		else if (per >= 80 && per <= 90)
			Console.WriteLine("\tGrade is A");
		else if(per >= 91)
			Console.WriteLine("\tGrade is A+");
	}
}
