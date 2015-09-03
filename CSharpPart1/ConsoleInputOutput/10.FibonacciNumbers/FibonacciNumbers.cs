using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the last Fibonacci member:");
        int counter = int.Parse(Console.ReadLine());

        decimal firstNumber = 0m;
        decimal secondNumber = 1m;
        decimal sum;

        for (int i = 0; i < counter; i++)
        {
            Console.Write(" {0},", firstNumber);

            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
    }
}