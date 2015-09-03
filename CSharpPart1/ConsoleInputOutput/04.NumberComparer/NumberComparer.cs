using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter number a:");
        double numberA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double numberB = double.Parse(Console.ReadLine());
        double greater = numberA < numberB ? numberB : numberA;
        Console.WriteLine("Greater:{0}", greater);
    }
}