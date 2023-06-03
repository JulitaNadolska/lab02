using System;
public class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the length of side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        if (a == b && b == c)
        {
            Console.WriteLine("The given sides can form an equilateral triangle.");
        }
        else
        {
            Console.WriteLine("The given sides can't form an equilateral triangle.");
        }
    }
}