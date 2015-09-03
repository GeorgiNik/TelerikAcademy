using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter Number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number b:");
        double b = double.Parse(Console.ReadLine());
        double swap;

        if (a > b)
        {
            swap = a;
            a = b;
            b = swap;
            
        }
        Console.WriteLine("Result:{0} {1}", a, b);
    }
}