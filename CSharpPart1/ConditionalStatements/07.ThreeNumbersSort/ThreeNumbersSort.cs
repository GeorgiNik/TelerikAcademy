using System;

class ThreeNumbersSort
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number");
        double third = double.Parse(Console.ReadLine());

        if (third > second)
        {
            third = third + second;
            second = third - second;
            third = third - second;
        }
        if (third > first)
        {
            third = third + first;
            first = third - first;
            third = third - first;
        }
        if (second > first)
        {
            second = second + first;
            first = second - first;
            second = second - first;
        }
        Console.WriteLine("{0} {1} {2}", first, second, third);

    }
}
