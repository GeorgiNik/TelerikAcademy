using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter number a:");
        int a = int.Parse(Console.ReadLine());
        string aToBinary = Convert.ToString(a, 2);
        Console.WriteLine("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0, -10:X}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        
    }
}