using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position p: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int newNumber = number & mask;
        int bit = newNumber >> p;

        Console.WriteLine(bit);
    }
}
