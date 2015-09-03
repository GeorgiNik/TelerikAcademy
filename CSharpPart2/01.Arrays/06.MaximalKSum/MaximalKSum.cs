//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Array.Reverse(array);
        for (int i = 0; i < k; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("The sum of the greatest {0} numbers in the array is {1}.", k, sum);
    }
}
