using System;
public class MyProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the weight [kg]: ");
        double weight = Convert.toInt32(Console.ReadLine());

        Console.WriteLine("Enter the height [m]: ");
        double height = Convert.toInt32(Console.ReadLine());

        double BMI = weight / (height * height);

        Console.WriteLine("Your BMI ratio is: " + BMI);

        if (BMI < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Your weight is correct.");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You have obesity.");
        }
    }
}

