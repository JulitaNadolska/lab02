using System;
public class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the number a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("Bigger number is: " + a);
        }
        else
        {
            Console.WriteLine("Bigger number is: " + b);
        }
    }
}