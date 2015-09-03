using System;

class DivideSevenFive
{
    private static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        bool result = true;
        if (number % 7 == 0 && number % 5 == 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            result = false;
            Console.WriteLine(result);
        }
    }
}