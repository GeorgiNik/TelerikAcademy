using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Random number =new Random();
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max:");
        int max = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", number.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}
