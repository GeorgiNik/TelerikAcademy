using System;

class MinMaxSumAverage
{
    static void Main()
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average = 0.0;
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter {0} number:",i);
            int number = int.Parse(Console.ReadLine());
            if (number<min)
            {
                min = number;
            }
            if (number>max)
            {
                max = number;
            }
            sum += number;
        }
        average = (double)sum / n;
        Console.WriteLine();
        Console.WriteLine("min="+min);
        Console.WriteLine("max=" + max);
        Console.WriteLine("sum=" + sum);
        Console.WriteLine("avg={0:f2}",average);
    }
}
