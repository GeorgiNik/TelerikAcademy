using System;

class VariableDataExchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int exchange;
        Console.WriteLine("Before exchange a:{0} b:{1}", a, b);
        exchange = a;
        a = b;
        b = exchange;
        Console.WriteLine("After exchange a:{0} b:{1}", a, b);
    }
}

