using System;

class Bitwise
{
    static void Main()
    {
        Console.Write("Enter a posivite whole number: ");
        uint number = uint.Parse(Console.ReadLine());
         
        uint mask = 1 << 3;
        uint newNumber = mask & number;
        uint bit = newNumber >> 3;

        Console.WriteLine(bit);
    }
}
