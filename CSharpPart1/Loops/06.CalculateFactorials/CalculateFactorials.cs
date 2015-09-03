using System;
using System.Numerics;
class CalculateFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialNK=1;
        
        for (int i = k+1; i <= n; i++)
        {
            factorialNK *= i;
        }
        
        Console.WriteLine("n!/k! is: {0}", factorialNK);
    }
}
