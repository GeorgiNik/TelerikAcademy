using System;

class CalculateGCD
{
    public static int Gcd(int a, int b)
    {
        
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            return b;
        else
            return a;
    }
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("GCD(a,b) is : {0}",Gcd(a,b));
        
    }
}
