// C# implementation to demonstrate
// the Boxing
using System;
class BxUnBx
{

    // Main Method
    static public void Main()
    {
        int num = 2022;

        object obj = num; //boxing
        num = 100;
        int i = (int)obj; //unboxing

        System.Console.WriteLine
        ("Value - type value of num is : {0}", num);
        System.Console.WriteLine
        ("Object - type value of obj is : {0}", obj);
        
        System.Console.WriteLine
        ("Value - Unboxed value of obj is: {0}", obj);
    }
}