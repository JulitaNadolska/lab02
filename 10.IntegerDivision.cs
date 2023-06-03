using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Give a number (N): ");
        int number = int.Parse(Console.ReadLine());

        int lastDigit = number % 10;

        Console.WriteLine("The last digit of the number is: " + lastDigit);
    }
}