using System;

class IsPrime
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number == 1) isPrime = true;
        for(int i=2;i<=Math.Sqrt(number);i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine("Number IsPrime? --> {0}",isPrime);
    }
}
