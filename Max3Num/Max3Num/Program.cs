using System;

public class Max
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 3: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 >= n2 && n1 >= n3)
            Console.WriteLine(n1 + " is the largest number.");

        else if (n2 >= n1 && n2 >= n3)
            Console.WriteLine(n2 + " is the largest number.");

        else
            Console.WriteLine(n3 + " is the largest number.");
    }
}