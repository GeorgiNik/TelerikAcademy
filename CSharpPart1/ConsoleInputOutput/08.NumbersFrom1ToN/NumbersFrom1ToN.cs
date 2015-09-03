using System;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }

    }
}
