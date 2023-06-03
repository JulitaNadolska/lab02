using System;
public class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select action: ");
        Console.WriteLine("1 - addition");
        Console.WriteLine("2 - subtraction");
        Console.WriteLine("3 - multiplication");
        Console.WriteLine("4 - division");
        int numberAction = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (numberAction)
        {
            case 1:
                result = firstNumber + secondNumber;
                break;
            case 2:
                result = firstNumber - secondNumber;
                break;
            case 3:
                result = firstNumber * secondNumber;
                break;
            case 4:
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    Console.WriteLine("Error: Dividing by zero!");
                    Console.WriteLine("Result: {0}/0", firstNumber);
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid Action!");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}






