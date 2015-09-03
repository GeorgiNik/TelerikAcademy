using System;
using System.Linq;

/*Problem 14. Integer calculations
------------------------------------------------------------------------------------------------------
Write methods to calculate minimum, maximum, average, sum and product of given set of integer set.
Use variable number of arguments.
*/
class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The Minimum of set integers: {0}", Min(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Maximum of set integers: {0}", Max(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Average Sum of set integers: {0}", Average(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Sum of set integers: {0}", Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Product of set integers: {0}\n", Product(1, 2, 3, 4, 5, 6, 7, 8, 9));
    }

    static int Min(params int[] set)
    {
        int min = set[0];

        for (int i = 1; i < set.Length; i++)
        {
            if (set[i] < min) min = set[i];
        }
        return min;
    }

    static int Max(params int[] set)
    {
        int max = set[0];

        for (int i = 1; i < set.Length; i++)
        {
            if (set[i] > max) max = set[i];
        }
        return max;
    }

    static int Sum(params int[] set)
    {
        return set.Sum();
    }

    static decimal Average(params int[] set)
    {
        return (decimal)Sum(set) / set.Length;
    }

    static int Product(params int[] set)
    {
        return set.Aggregate(1, (current, t) => current * t);
    }
}