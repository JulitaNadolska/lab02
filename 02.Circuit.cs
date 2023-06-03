using System;

public class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Give the area of the circle: ");
        double area = Convert.ToDouble(Console.ReadLine());

        double radius = Math.Sqrt(area / Math.PI);
        double circuit = 2 * Math.PI * radius;

        Console.WriteLine("The circumference of the circle is: " + circuit);
    }
}
