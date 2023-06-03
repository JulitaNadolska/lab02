using System;
public class MyProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter r: ");
        double r = Convert.ToDouble(Console.ReadLine());

        if (x * x * +y * y <= r * r)
        {
            Console.WriteLine("The entered coordinates are within the circle.");
        }
        else
        {
            Console.WriteLine("The entered coordinates are NOT within the circle.");
        }
    }
}