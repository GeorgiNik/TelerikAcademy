using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number to sum:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number to sum:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number to sum:");
        double c = double.Parse(Console.ReadLine());
        double sum;
        sum = a + b + c;

        Console.WriteLine("The sum of the three numbers is : {0}",sum);
    }
}