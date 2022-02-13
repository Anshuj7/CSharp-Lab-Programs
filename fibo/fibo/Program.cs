using System;
class Fibo
{
    public static void Main(string[] args)
    {
        int num1 = 0, num2 = 1, num3, num4, num, counter=3;
        Console.Write("Enter a number: "); 
        num = int.Parse(Console.ReadLine());
        Console.Write(num1 + " " + num2);
        while (counter <= num)
        {
            num3 = num1 + num2;
            if (counter >= num)
                break;
            Console.Write(" " + num3);
            num1 = num2;
            num2 = num3;
            counter++;
            }
        }
}