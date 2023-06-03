using System;
public class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Enter number a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("No results");
        }
        else
        {
            int x = a * d + b * c;
            int y = b * d;

            Console.WriteLine("Fraction: " + x + "/" + y);
        }
    }
}






