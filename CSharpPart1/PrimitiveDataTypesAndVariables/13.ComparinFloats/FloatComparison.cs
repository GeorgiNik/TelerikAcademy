using System;

class FloatComparison
{
    static void Main()
    {
        Console.WriteLine("Please enter first number to compare :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number to compare:");
        double b = double.Parse(Console.ReadLine());
        bool equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("a == b --> " + equal);
    }
}

