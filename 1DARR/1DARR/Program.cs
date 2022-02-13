using System;
public class Array1D
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };//Declaration and Initialization of array  

        Console.WriteLine("Entered Array is as: ");
        //traversing array  
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
    }
}