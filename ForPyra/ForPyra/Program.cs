using System;
class ForPyra
{
    public static void Main(string[] args)
    {
        int row, sp, col, revcol;
        Console.WriteLine("Enter the no. of rows for pyramid: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (row = 1; row <= n; row++)
        {
            for (sp = 1; sp <= n - row; sp++)
            {
                Console.Write(' ');
            }
            for (col = 1; col <= row; col++)
            {
                Console.Write(col);
            }
            for (revcol = col - 2; revcol >= 1; revcol--)
            {
                Console.Write(revcol);
            }
            Console.WriteLine();
        }
    }
}
