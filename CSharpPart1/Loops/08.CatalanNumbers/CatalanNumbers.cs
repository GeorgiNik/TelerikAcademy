using System;
using System.Numerics;


class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());

        BigInteger chislitel = 1;
        BigInteger znamenatel = 1;
        if (n > 0 && n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                chislitel *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                znamenatel *= i;
            }
            BigInteger result = chislitel / znamenatel;
            Console.WriteLine("The {0} Catalan number is: {1}", n, result);
        }
        else
        {
            Console.WriteLine("The number must be bigger than zero");
        }
    }
}
