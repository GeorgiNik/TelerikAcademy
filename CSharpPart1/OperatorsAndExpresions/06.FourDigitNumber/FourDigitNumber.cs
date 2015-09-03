using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int abcd = int.Parse(Console.ReadLine());

        int d = abcd % 10;
        int c = (abcd / 10) % 10;
        int b = (abcd / 100) % 10;
        int a = (abcd / 1000) % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a); 
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c); 
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

    }
}

