using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        double arithmeticMean;

        arithmeticMean = (a + b + c) / 3;
        Console.WriteLine("The arithmetic mean is: " + arithmeticMean);
    }

}