using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(10000 + b);
    }
}

