using System;

class FactorialSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        decimal xAtPowerN = 1.00m;
        decimal factorial = 1.00m;
        decimal sum = 1.00m;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xAtPowerN *= x;
            sum += (factorial / xAtPowerN);
        }
        Console.WriteLine("{0 :F5}", sum);
    }
}
