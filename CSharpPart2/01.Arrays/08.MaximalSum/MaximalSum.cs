//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
using System;

class MaximalSum
{
    static void Main()
    {   //int[] array = { -2, -3, 4, -1, -2, 1, 5, -3 };
        //int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int currSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;
        int maxSum = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (currSum <= 0)
            {
                startIndex = i;
                currSum = 0;
            }

            currSum += array[i];

            if (currSum > maxSum)
            {
                maxSum = currSum;
                tempIndex = startIndex;
                endIndex = i;
            }
        }
        Console.WriteLine();
        Console.Write("The best sequance is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(i != (endIndex ) ? "{0}, " : "{0}\n", array[i]);
            
        }
        Console.WriteLine();
        Console.WriteLine("The max sum is: {0}", maxSum);

    }
}
