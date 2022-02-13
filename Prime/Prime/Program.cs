using System;
    class Program
    {
        static void Main(string[] args)
        {
            int num, counter;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (counter = 2; counter <= num / 2; counter++)
            {
                if ((num % counter) == 0)
                    break;
            }
            if (num == 1)
                Console.WriteLine(num + " is neither prime nor composite");
            else if (counter < (num / 2))
                Console.WriteLine(num + " is not prime number");
            else
                Console.WriteLine(num + " is prime number");
        }
    }
