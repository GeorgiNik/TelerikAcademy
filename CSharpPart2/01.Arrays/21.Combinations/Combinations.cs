//Problem 21.* Combinations of set

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

using System;
using System.Collections.Generic;

class Combinations
{
    
    static int n = int.Parse(Console.ReadLine());
    
    static int k = int.Parse(Console.ReadLine());

    public static void Combination(int[] array, int index, int currNum)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currNum; i <= n; i++)
            {
                array[index] = i;
                Combination(array, index + 1, i + 1);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("{" + String.Join(",", array) + "}");
    }

    static void Main()
    {
        
        int[] array = new int[k];
        Combination(array, 0, 1);
    }
}