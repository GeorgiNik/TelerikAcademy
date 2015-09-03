//Problem 20.* Variations of set

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
using System;

class Variations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Variation(int[] array, int index)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Variation(array, index + 1);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("{" + String.Join(",", array) + "}");
    }

    static void Main()
    {
        int[] variations = new int[k];
        Variation(variations, 0);
    }
}
